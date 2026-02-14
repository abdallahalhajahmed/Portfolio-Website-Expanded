import { 
  FaHtml5, 
  FaCss3Alt, 
  FaJs, 
  FaWordpress, 
  FaPython, 
  FaJava, 
  FaReact, 
  FaBootstrap, 
  FaGithub, 
  FaDatabase,
  FaJenkins,
  FaAws,
  FaLinux,
  FaLeaf
} from "react-icons/fa";

import { 
  SiLangchain, 
  SiFlask,
  SiSpringboot,
  SiSelenium,
  SiCucumber,
  SiTerraform,
  SiTypescript,
  SiFlutter,
  SiSharp,
  SiGithubactions,
  SiDotnet,
  SiPlaywright
} from "react-icons/si";

import { TbApi } from "react-icons/tb";
import { BiTestTube } from "react-icons/bi";

function Skills() {
  return (
    <section id="skills" className="container">
      <div className="row justify-content-center">
        <h4 className="projects-header text-center" style={{ marginTop: "100px", fontSize: "20px" }}>
          PROFICIENT IN
        </h4>
      </div>

      <div className="row m-2 justify-content-center">

        {[
          { icon: <FaJava size={50} />, title: "Java" },
          { icon: <SiSpringboot size={50} />, title: "Spring Boot" },
          { icon: <FaHtml5 size={50} />, title: "HTML5" },
          { icon: <FaCss3Alt size={50} />, title: "CSS3" },
          { icon: <FaJs size={50} />, title: "JavaScript" },
          { icon: <SiSelenium size={50} />, title: "Selenium" },
          { icon: <SiCucumber size={50} />, title: "BDD (Cucumber)" },
          { icon: <SiGithubactions size={50} />, title: "CI/CD (GitHub Actions)" },
          { icon: <FaBootstrap size={50} />, title: "Bootstrap" },
          { icon: <FaGithub size={50} />, title: "Git" },
        ].map((skill, index) => (
          <div key={index} className="col-6 m-2 skill-box text-center mb-5" style={{ background: "#e9e6e2" }}>
            <div className="skill-icon mb-2">
              <i className="skill-icon">{skill.icon}</i>
            </div>
            <h6 className="skill-title">{skill.title}</h6>
          </div>
        ))}

      </div>

      <div className="row justify-content-center">
        <h4 className="projects-header mt-5 mb-3 text-center" style={{ fontSize: "20px" }}>
          SECONDARY SKILLS
        </h4>
      </div>

      <div className="row justify-content-center">

        {[
          { icon: <SiSharp size={50} />, title: "C#" },
          { icon: <SiDotnet size={50} />, title: "ASP.NET" },
          { icon: <FaWordpress size={50} />, title: "WordPress" },
          { icon: <FaPython size={50} />, title: "Python" },
          { icon: <SiLangchain size={50} />, title: "LangChain" },
          { icon: <FaReact size={50} />, title: "React" },
          { icon: <SiFlutter size={50} />, title: "Flutter" },
          { icon: <FaDatabase size={50} />, title: "SQL" },
          { icon: <SiFlask size={50} />, title: "Flask" },
          { icon: <BiTestTube size={50} />, title: "Unit Testing & Mocking" },
          { icon: <TbApi size={50} />, title: "REST APIs" },
          { icon: <FaLeaf size={50} />, title: "Thymeleaf" },
          { icon: <FaJenkins size={50} />, title: "CI/CD (Jenkins)" },
          { icon: <FaAws size={50} />, title: "AWS" },
          { icon: <FaLinux size={50} />, title: "Linux" },
          { icon: <SiTypescript size={50} />, title: "TypeScript" },
        ].map((skill, index) => (
          <div key={index} className="col-6 m-2 skill-box text-center mb-5" style={{ background: "#e9e6e2" }}>
            <div className="skill-icon mb-2">
              <i className="skill-icon">{skill.icon}</i>
            </div>
            <h6 className="skill-title">{skill.title}</h6>
          </div>
        ))}

      </div>
    </section>
  );
}

export default Skills;
