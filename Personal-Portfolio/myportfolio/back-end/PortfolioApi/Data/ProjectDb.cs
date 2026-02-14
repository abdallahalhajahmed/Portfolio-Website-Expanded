using Microsoft.EntityFrameworkCore;
using PortfolioApi.Models;

namespace PortfolioApi.Data;

public class ProjectDb : DbContext
{
    public ProjectDb(DbContextOptions<ProjectDb> options)
        : base(options) { }

    public DbSet<Project> Projects => Set<Project>();
}
