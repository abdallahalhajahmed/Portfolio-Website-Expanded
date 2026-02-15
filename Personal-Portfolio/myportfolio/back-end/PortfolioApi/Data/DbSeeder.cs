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
                    "The Projects section dynamically fetches data from a Swagger API backed by an in-memory database; the API's architecture entails using \n" +
                    "Models, DTOs, dependency injection, and RESTful CRUD endpoints.\n"+
                    "I also implemented a CD pipeline which, using a Render Webhook, automatically deploys the back-end to a Render instance whenever there are updates to my projects' section. \n"+
                    "The React front-end is deployed on a custom domain that I currently own, that is hosted by Hostinger.\n"+
                    "The ASP.NET back-end, hosted on Render, is accessible via a subdomain and can be accessed using the following link: api.abdallahalhajahmed/swagger (might take a couple of seconds to re-launce the Render instance).\n"+
                    "I pointed the subdomain to the Render instance using a DNS CNAME record in the domain's DNS settings.\n"+
                Link = "https://github.com/abdallahalhajahmed/Personal-Portfolio-Expanded",
                Button = "GitHub",
                Categories = "Full Stack"
            },
            new Project
            {
                Title = "Sparta Global Academy – Full Stack Spring Boot Application",
                Description =
                    "I Worked in a team of 5 to build and deploy this API using Spring Boot & Thymeleaf templates used for managing the Sparta Global Academy domain.\n" +
                    "This project includes the design of a clean layered architecture with Entities, DTOs, Controllers, Services, and JPA Repositories to manage courses, trainers, and trainees.\n" +
                    "It entails implementing full CRUD operations, enrolment logic, trainer assignments, and custom query methods following REST best practices.\n" +
                    "My main contributions included the following: being the Scrum Master; making sure the agile team members developed each individual app feature on a feature branch on GitHub before any code merges;" +
                    "containerising the application using Docker; creating the Courses API using clean Spring Boot architecture; contributing to the Thymeleaf front-end, ensuring good web design; contributing to writing the BDD Cucumber scenarios, Serenity tests and Unit & Mockito tests;" +
                    "creating a CI pipeline that runs both Unit tests and RestAssured API tests automatically before performing an 'auto-merge'; creating a CD pipleline that runs the same said tests and deploys the applicaion to a live Render instance\n" +
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
                    "Future plans include event listings, a membership programme, a shop, and full e-commerce integration.\n",
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
                    "The front-end of this web-based application was built using Bootstrap, HTML5, and JavaScript while the back end was built with Python, LangChain, and Flask. \n",
                Link = "https://www.youtube.com/watch?v=WeAxOtVvOJg",
                Button = "Video Demo",
                Categories = "Full Stack"
            },          
            new Project
            {
                Title = "Java Test Automation Project – Web Testing Framework",
                Description =
                    "I Designed and built a full web automation framework using Selenium WebDriver, Cucumber, and the Page Object Model (POM) to test a Dockerised web application.\n" +
                    "I mainly automated critical user journeys including sign-up, sign-in, navigation, search, cart, and account flows using Gherkin feature files and reusable step definitions.\n" +
                    "The framework was structured with separate Actions, Locators, Utilities, and Step Definition layers to ensure scalability and maintainability.\n" +
                    "I implemented unit tests with JUnit and Mockito, generated HTML test reports, and created a defect report for failed scenarios.\n" +
                    "I also integrated a GitHub Actions CI pipeline to automatically build the project, run the tests, and auto-merge GitHub branches when the tests pass.",
                Link = "https://github.com/abdallahalhajahmed/Web-Testing-Framework",
                Button = "GitHub",
                Categories = "Test Automation"
            },
            new Project
            {
                Title = "Java CI/CD Pipeline – GitHub Actions & Docker",
                Description =
                    "I engineered a complete CI/CD pipeline using GitHub Actions to automate building a Java Spring Boot project, running the tests, and creating a Docker image for the application.\n" +
                    "The CI workflow runs JUnit unit tests with Mockito ensuring that any changes are reliable before merging into the main branch on GitHub.\n" +
                    "I implemented Continuous Deployment steps that run the tests again and build a Docker image that is then pushed to Docker Hub.\n" +
                    "I improved code coverage by writing additional unit tests, resolving failing builds, and ensuring pipeline stability.\n" +
                Link = "https://github.com/abdallahalhajahmed/ci-cd-pipeline-with-github-actions-and-docker",
                Button = "GitHub",
                Categories = "Test Automation"
            },
            new Project
            {
                Title = "Sales Analytics Sheet",
                Description = 
                    "I developed a mobile-based Sales Analytics Sheet using Flutter to help sales representatives track their sales gauges efficiently when they perform door-to-door sales.\n" +
                    "It was designed to improve productivity, by replacing the traditional pen-and-paper method of writing down sales guages, and it supports on-the-go data entry and real-time analytics.\n" +
                Link = "https://github.com/abdallahalhajahmed/GaugeSheet",
                Button = "GitHub",
                Categories = "Mobile"
            },
            new Project
            {
                Title = "Ciphertext Only Attack (COA)",
                Description = 
                    "As part of my MSc Software Development I created a decryption program inspired by the Enigma machine which was used during WWII.\n" +
                    "It uses a rotor-based encryption scheme and checks for any valid English words.\n" +
                    "The programme mainly performs a dictionary attack to decipher the English text of a ciphertext (encoded text).\n",
                Link = "https://github.com/abdallahalhajahmed/Ciphertext-Only-Attack-COA-",
                Button = "GitHub",
                Categories = "Back End" 
            }
        );

        db.SaveChanges();
    }
}
