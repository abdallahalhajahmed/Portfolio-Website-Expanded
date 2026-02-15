using Microsoft.EntityFrameworkCore;
using PortfolioApi.Data;
using PortfolioApi.DTOs;
using PortfolioApi.Models;

var builder = WebApplication.CreateBuilder(args);

// 1. Add services BEFORE Build
builder.Services.AddDbContext<ProjectDb>(opt =>
    opt.UseInMemoryDatabase("PortfolioDb"));

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// Add CORS here BEFORE builder.Build()
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowReact", policy =>
        policy.WithOrigins("http://localhost:3000")
              .AllowAnyHeader()
              .AllowAnyMethod());
});

// 2. Build app
var app = builder.Build();

// 3. Configure middleware
app.UseSwagger();
app.UseSwaggerUI();
app.UseCors("AllowReact");

// 4. Seed database
using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<ProjectDb>();
    DbSeeder.Seed(db);
}

// 5. Route group
var projects = app.MapGroup("/projects");

projects.MapGet("/", GetAllProjects);
projects.MapGet("/{id}", GetProjectById);
projects.MapPost("/", CreateProject);
projects.MapPut("/{id}", UpdateProject);
projects.MapDelete("/{id}", DeleteProject);

// 6. Endpoint handlers
static async Task<IResult> GetAllProjects(ProjectDb db)
{
    var projects = await db.Projects
        .Select(p => new ProjectDTO(p))
        .ToListAsync();
    return TypedResults.Ok(projects);
}

static async Task<IResult> GetProjectById(int id, ProjectDb db)
{
    var project = await db.Projects.FindAsync(id);
    return project is null
        ? TypedResults.NotFound()
        : TypedResults.Ok(new ProjectDTO(project));
}

static async Task<IResult> CreateProject(ProjectDTO dto, ProjectDb db)
{
    var project = new Project
    {
        Title = dto.Title,
        Description = dto.Description,
        Link = dto.Link,
        Button = dto.Button,
        Categories = dto.Category != null
            ? string.Join(",", dto.Category)
            : null
    };

    db.Projects.Add(project);
    await db.SaveChangesAsync();

    return TypedResults.Created($"/projects/{project.Id}",
        new ProjectDTO(project));
}

static async Task<IResult> UpdateProject(int id, ProjectDTO dto, ProjectDb db)
{
    var project = await db.Projects.FindAsync(id);
    if (project is null) return TypedResults.NotFound();

    project.Title = dto.Title;
    project.Description = dto.Description;
    project.Link = dto.Link;
    project.Button = dto.Button;
    project.Categories = dto.Category != null
        ? string.Join(",", dto.Category)
        : null;

    await db.SaveChangesAsync();
    return TypedResults.NoContent();
}

static async Task<IResult> DeleteProject(int id, ProjectDb db)
{
    var project = await db.Projects.FindAsync(id);
    if (project is null) return TypedResults.NotFound();

    db.Projects.Remove(project);
    await db.SaveChangesAsync();
    return TypedResults.NoContent();
}

// 7. Run app

app.Run();
