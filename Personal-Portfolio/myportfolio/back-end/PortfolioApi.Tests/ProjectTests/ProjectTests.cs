using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.EntityFrameworkCore;
using PortfolioApi.Data;
using PortfolioApi.Models;
using System;
using System.Threading.Tasks;
using System.Linq;

namespace PortfolioApi.Tests.ProjectTests
{
    [TestClass]
    public class ProjectTests
    {
        private ProjectDb _db;

        [TestInitialize]
        public void Setup()
        {
            var options = new DbContextOptionsBuilder<ProjectDb>()
                .UseInMemoryDatabase(databaseName: Guid.NewGuid().ToString())
                .Options;

            _db = new ProjectDb(options);

            // Seed your data
            _db.Projects.Add(new Project { Title = "The first project" });
            _db.Projects.Add(new Project { Title = "The second project" });
            _db.SaveChanges();
        }

        [TestMethod]
        public async Task GetAllProjects_ReturnsAllProjects()
        {
            var projects = await _db.Projects.ToListAsync();
            Assert.AreEqual(2, projects.Count);
        }

        [TestMethod]
        public async Task GetProjectById_ExistingId_ReturnsProject()
        {
            var project = await _db.Projects.FirstAsync();
            Assert.IsNotNull(project);
            Assert.AreEqual("The first project", project.Title);
        }

        [TestMethod]
        public async Task CreateProject_AddsProjectToDb()
        {
            var newProject = new Project
            {
                Title = "New Project",
                Description = "New Description",
                Categories = "Back End"
            };

            _db.Projects.Add(newProject);
            await _db.SaveChangesAsync();

            var projectInDb = await _db.Projects.FindAsync(newProject.Id);
            Assert.IsNotNull(projectInDb);
            Assert.AreEqual("New Project", projectInDb.Title);
            Assert.AreEqual("New Description", projectInDb.Description);
            Assert.AreEqual("Back End", projectInDb.Categories);
        }

        [TestMethod]
        public async Task UpdateProject_ExistingProject_UpdatesFields()
        {
            var project = await _db.Projects.FirstAsync();
            project.Title = "New Title for the first project";
            await _db.SaveChangesAsync();

            var updated = await _db.Projects.FindAsync(project.Id);
            Assert.AreEqual("New Title for the first project", updated.Title);
        }

        [TestMethod]
        public async Task DeleteProject_RemovesProject()
        {
            var project = await _db.Projects.FirstAsync();
            _db.Projects.Remove(project);
            await _db.SaveChangesAsync();

            var deleted = await _db.Projects.FindAsync(project.Id);
            Assert.IsNull(deleted);
            Assert.AreEqual(1, await _db.Projects.CountAsync());
        }
    }
}
