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
                    "I initially built this portfolio website using a React front-end to showcase my skills and my development as a software developer. This last week, I decided to expand it as a full-stack application using ASP.NET APIs for the back-end, which now \n" +
                    " enables the projects section to fetch the data from a Swagger API.\n"+
                    "I also implemented a CD pipeline which automatically runs Unit Tests written with MSTest and deploys the back-end to a Render instance. \n"+
                    "The front-end is deployed on a custom domain that I currently own, that is hosted by Hostinger.\n"+
                    "The back-end, hosted on Render, is also accessible via the Hostinger subdomain: api.abdallahalhajahmed.com/swagger.\n",
                Link = "https://github.com/abdallahalhajahmed/Portfolio-Website-Expanded",
                Button = "GitHub",
                Categories = "Full Stack"
            },
            new Project
            {
                Title = "Sparta Global Academy – Full Stack Spring Boot Application",
                Description =
                    "I worked in a team of 5 to build and deploy a Sparta Global Academy API used for managing courses, trainers, and students details.\n" +
                    "My main contributions included: being the Scrum Master; " +
                    "containerising the application using Docker; creating the Courses API using clean Spring Boot architecture; contributing to the Thymeleaf front-end and ensuring good web design; contributing to writing the BDD Cucumber scenarios, Serenity tests and Unit & Mockito tests; " +
                    "creating a CI/CD pipeline that runs both Unit tests and RestAssured API tests automatically before performing an 'auto-merge' and deploying the applicaion to a live Render instance.\n",
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
                    "The tutor leverages the GPT Large Language Model and uses Retrieval Augmented Generation and Prompt Engineering techniques to provide a personalised and interactive learning experience for the pupil.\n" +
                    "I built the front-end using Bootstrap, HTML5, and JavaScript and the back end using Python, LangChain, and Flask. \n",
                Link = "https://www.youtube.com/watch?v=WeAxOtVvOJg",
                Button = "Video Demo",
                Categories = "Full Stack"
            },          
            new Project
            {
                Title = "Java Test Automation Project – Web Testing Framework",
                Description =
                    "I built a full web automation framework using Selenium WebDriver, Cucumber, and the Page Object Model (POM) to test a Dockerised web application.\n" +
                    "I mainly automated important user journeys including authentication, navigation, searching, cart, and account details using Gherkin feature files and step definitions.\n" +
                    "I also integrated a GitHub Actions CI pipeline to automatically build the project, run the tests, and auto-merge GitHub branches when the tests pass.",
                Link = "https://github.com/abdallahalhajahmed/Web-Testing-Framework",
                Button = "GitHub",
                Categories = "Test Automation"
            },
            new Project
            {
                Title = "Java CI/CD Pipeline – GitHub Actions & Docker",
                Description =
                    "I engineered a complete CI/CD pipeline using GitHub Actions to automate building a Java Spring Boot application, running the tests, and creating a Docker image for the application.\n" +
                    "The CI workflow runs JUnit unit tests with Mockito ensuring that any changes are reliable before merging into the main branch on GitHub.\n" +
                    "The CD pipeline also runs the tests and builds a Docker image that is then deployed to Docker Hub.\n",
                Link = "https://github.com/abdallahalhajahmed/ci-cd-pipeline-with-github-actions-and-docker",
                Button = "GitHub",
                Categories = "Test Automation"
            },
            new Project
            {
                Title = "Sales Analytics Sheet",
                Description = 
                    "I developed a mobile-based Sales Analytics Sheet using Flutter to help sales representatives track their sales gauges efficiently when they perform door-to-door sales.\n" +
                    "It was designed to improve productivity, by replacing the traditional pen-and-paper method of writing down sales guages.\n",
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
