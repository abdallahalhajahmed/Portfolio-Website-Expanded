namespace PortfolioApi.DTOs;

public class ProjectDTO
{
    public int Id { get; set; }
    public string? Title { get; set; }
    public string? Description { get; set; }
    public string? Link { get; set; }
    public string? Button { get; set; }
    public string[]? Category { get; set; }

    public ProjectDTO() { }

    public ProjectDTO(Models.Project project)
    {
        Id = project.Id;
        Title = project.Title;
        Description = project.Description;
        Link = project.Link;
        Button = project.Button;
        Category = project.Categories?.Split(',');
    }
}
