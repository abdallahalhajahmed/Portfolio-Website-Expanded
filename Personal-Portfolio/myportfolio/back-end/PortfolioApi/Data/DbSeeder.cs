using PortfolioApi.Models;

namespace PortfolioApi.Data;

public static class DbSeeder
{
    public static void Seed(ProjectDb db)
    {
        if (db.Projects.Any()) return;

        db.Projects.AddRange(
            new Project
            {
                Title = "Personal Portfolio – Full Stack React & ASP.NET Core",
                Description =
                    "I initially built this portfolio website using a React front-end and responsive component-based architecture to showcase my skills and my development as a software developer. This last week, I decided to expand it as a full-stack application using ASP.NET Core Minimal APIs for the back end.\n" +
                    "The Projects section dynamically fetches data from a Swagger-documented API backed by an in-memory database.\n" +
                    "I implemented Models, DTOs, dependency injection, and RESTful CRUD endpoints.\n" +
                    "This project demonstrates full-stack integration, clean architecture principles, and modern .NET development practices.",
                Link = "https://github.com/abdallahalhajahmed/Personal-Portfolio-Expanded",
                Button = "GitHub",
                Categories = "Full Stack"
            },
            new Project
            {
                Title = "Sparta Global Academy – Full Stack Spring Boot Application",
                Description =
                    "Worked in a team of 5 to build and deploy this API using Spring Boot & Thymeleaf templates for managing the Sparta Global Academy domain.\n" +
                    "Designed a clean layered architecture with Entities, DTOs, Controllers, Services, and JPA Repositories to manage courses, trainers, and trainees.\n" +
                    "Implemented full CRUD operations, enrolment logic, trainer assignments, and custom query methods following REST best practices.\n" +
                    "Containerised the application using Docker and deployed it to a live Render instance with a complete CI/CD pipeline using GitHub Actions.\n" +
                    "Developed comprehensive automated testing including API tests with Rest Assured, unit tests with JUnit and Mockito, and Behaviour-Driven Development (BDD) tests using Serenity, which were integrated into GitHub Actions workflows.\n",
                Link = "https://github.com/eoelliot1/SPA_API",
                Button = "GitHub",
                Categories = "Full Stack"
            },
            new Project
            {
                Title = "PalCafe",
                Description = 
                    "I designed and built this website for PalCafe, a community-led initiative and charity working to create Glasgow’s first Palestinian cultural café.\n" +
                    "The site was developed on WordPress using Elementor, Astra theme, Forminator, and custom HTML5 & CSS3.\n" +
                    "This website is still a work in progress and I am maintaining it.\n" +
                    "Future plans include event listings, a membership programme, a shop, and full e-commerce integration.\n" +
                    "The project demonstrates front-end web development and community-focused design.",
                Link = "https://palcafe.org/",
                Button = "URL",
                Categories = "Front End"
            },
            new Project
            {
                Title = "AI-powered French Tutor",
                Description = 
                    "I built an AI-powered French tutor for young high school pupils looking to improve their French Vocabulary.\n" +
                    "The tutor leverages the GPT Large Language Model and uses Retrieval Augmented Generation and Prompt Engineering techniques to provide a personalised and highly interactive learning experience for the pupil\n" +
                    "The front-end uses Bootstrap, HTML5, and CSS3, while the back-end is built with Python, LangChain, and Flask.\n" +
                    "The front-end of this web-based application was built using Bootstrap, HTML5, and JavaScript while the back end was built with Python, LangChain, and Flask.\n" +
                    "Proud to be one of few students in my cohort to have achieved a distinction grade (A4) in this project."+
                    "This project demonstrates full-stack AI-powered web development.",
                Link = "https://www.youtube.com/watch?v=WeAxOtVvOJg",
                Button = "Video Demo",
                Categories = "Full Stack"
            },          
            new Project
            {
                Title = "Java Test Automation Project – Web Testing Framework",
                Description =
                    "Designed and built a full web automation framework using Selenium WebDriver, Cucumber, and the Page Object Model (POM) to test a Dockerised web application.\n" +
                    "Automated critical user journeys including sign-up, sign-in, navigation, search, cart, and account flows using Gherkin feature files and reusable step definitions.\n" +
                    "Structured the framework with separate Actions, Locators, Utilities, and Step Definition layers to ensure scalability and maintainability.\n" +
                    "Implemented unit tests with JUnit and Mockito, generated HTML test reports, and logged structured defect reports for failed scenarios.\n" +
                    "Integrated GitHub Actions CI pipelines to automatically build, run tests, validate pull requests, and auto-merge on successful verification.",
                Link = "https://github.com/abdallahalhajahmed/Web-Testing-Framework",
                Button = "GitHub",
                Categories = "Test Automation"
            },
            new Project
            {
                Title = "Java CI/CD Pipeline – GitHub Actions & Docker",
                Description =
                    "Engineered a complete CI/CD pipeline using GitHub Actions to automate build, test, and Docker image creation for a Java application.\n" +
                    "Configured Continuous Integration workflows to run JUnit unit tests with Mockito mocking on every Pull Request, enforcing quality gates before merge.\n" +
                    "Implemented Continuous Deployment steps that build a Docker image and push it to Docker Hub after successful merges to the main branch.\n" +
                    "Improved code coverage by writing additional unit tests, resolving failing builds, and ensuring pipeline stability.\n" +
                    "Documented the full workflow including branching strategy, contribution guidelines, and a CI/CD architecture diagram.",
                Link = "https://github.com/abdallahalhajahmed/ci-cd-pipeline-with-github-actions-and-docker",
                Button = "GitHub",
                Categories = "Test Automation"
            },
            new Project
            {
                Title = "Sales Analytics Sheet",
                Description = 
                    "I developed a mobile-based Sales Analytics Sheet using Flutter.\n" +
                    "This app helps sales representatives track their gauges efficiently in the field.\n" +
                    "It is mobile-friendly, intuitive, and designed to improve productivity.\n" +
                    "The app supports on-the-go data entry and real-time analytics.\n" +
                    "This project demonstrates full-stack mobile development.",
                Link = "https://github.com/abdallahalhajahmed/GaugeSheet",
                Button = "GitHub",
                Categories = "Mobile"
            },
            new Project
            {
                Title = "Ciphertext Only Attack (COA)",
                Description = 
                    "A decryption program inspired by the Enigma machine used during WWII.\n" +
                    "It uses a rotor-based encryption scheme and checks for valid English words.\n" +
                    "It handles ciphertext inputs and produces corresponding plaintext.\n" +
                    "This project showcases back-end programming and security logic.",
                Link = "https://github.com/abdallahalhajahmed/Ciphertext-Only-Attack-COA-",
                Button = "GitHub",
                Categories = "Back End"
            }
        );

        db.SaveChanges();
    }
}
