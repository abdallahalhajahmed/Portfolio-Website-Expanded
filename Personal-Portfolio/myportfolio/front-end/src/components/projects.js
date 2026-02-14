import { useEffect, useState } from "react";

function Projects() {
  const [projects, setProjects] = useState([]);
  const [selectedCategory, setSelectedCategory] = useState("All");

  // Fetch projects from API
  useEffect(() => {
    fetch("http://localhost:5219/projects") 
      .then(res => res.json())
      .then(data => setProjects(data))
      .catch(err => console.error(err));
  }, []);

  // Handle category selection
  const handleFilterClick = (category) => {
    setSelectedCategory(category);
  };

  // Filter projects based on selectedCategory
  const filteredProjects = selectedCategory === "All"
    ? projects
    : projects.filter((project) =>
        project.category.includes(selectedCategory)
      );

  return (
    <section id="projects" className="container">
      <div className="row">
        <h4 className="projects-header text-center" style={{ marginTop: "100px", marginBottom: "30px", fontSize: "20px" }}>
          MY PROJECTS
        </h4>
      </div>
      <div className="row">
        <h2 className="text-center mb-6">What I've worked on</h2>
      </div>

      <div className="projects-filter d-flex justify-content-center mb-4">
        {["All", "Full Stack", "Mobile", "Front End", "Back End", "Test Automation"].map((category) => (
          <button
            key={category}
            className={`m-2 btn btn-info ${selectedCategory === category ? "active" : ""}`}
            onClick={() => handleFilterClick(category)}
          >
            {category}
          </button>
        ))}
      </div>
      
      <div className="row row-cols-1 row-cols-md-2 g-4" id="projects">
        {filteredProjects.map((project, index) => (
          <div className="col" key={index}>
            <div id={project.id} className="card h-100">
              <div className="card-body d-flex flex-column">
                <h5 className="card-title mb-3">{project.title}</h5>
                <p className="card-text flex-grow-1">{project.description}</p>
                <div className="mt-auto">
                  <a 
                    className="btn btn-primary btn-lg mt-3" 
                    rel="noreferrer" 
                    href={project.link} 
                    target="_blank"
                  >
                    {project.button}
                  </a>
                </div>
              </div>
            </div>
          </div>
        ))}
      </div>
    </section>
  );
}

export default Projects;