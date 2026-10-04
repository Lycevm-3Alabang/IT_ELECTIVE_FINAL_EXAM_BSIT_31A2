using System.Collections.Generic;

namespace IT_ELECTIVE_FINAL_EXAM_BSIT_31A2.Models
{
    public static class TumalaProjectData
    {
        public static List<TumalaProject> All { get; } = new List<TumalaProject>
        {
            new TumalaProject
            {
                Id = 1,
                Title = "Midterm Activity 1 - Student Portfolio Web App",
                Category = "Midterm",
                GithubUrl = "https://github.com/NEILTUMALA/IT_ELECTIVE_2_Midterm_A1_Tumala_Neil.git",
                Description = "Responsive student portfolio web application.",

            },
            new TumalaProject
            {
                Id = 2,
                Title = "Prelim Activity 1 - FizzBuzz Algorithm Application",
                Category = "Prelim",
                GithubUrl = "https://github.com/NEILTUMALA/BSIT31E2_PRELIM_A1_TUMALA_NEIL.git",
                Description = "console application evaluating FizzBuzz algorithm logic.",

            },
            new TumalaProject
            {
                Id = 3,
                Title = "Prelim Activity 2 - Student Management Portal",
                Category = "Prelim",
                GithubUrl = "https://github.com/NEILTUMALA/BSIT31E2_PRELIM_A2_TUMALA_NEIL.git",
                Description = "Built for academic purposes.",
    
            },
            new TumalaProject 
            {
                Id = 4,
                Title = "Portfolio",
                Category = "Midterm",
                GithubUrl = "https://github.com/NEILTUMALA/IT_ELECTIVE_BSIT_31E2_PORTFOLIO_TUMALA.git",
                Description = "My brief information and accurate portfolio.",

            },
            new TumalaProject
            {
                Id = 5,
                Title = "HttpClientServer",
                Category = "Pre-Finals",
                GithubUrl = "https://github.com/NEILTUMALA/HttpClientStarter.git",
                Description = "were the httpclients are built.",
 
            },
            new TumalaProject
            {
                Id = 6,
                Title = "IT Elective PreFinal Exam - Student Portfolio Portal",
                Category = "Finals",
                GithubUrl = "https://github.com/NEILTUMALA/IT_ELECTIVE_2_BSIT_31E2_PREFINAL_EXAM_Tumala_Neil.git",
                Description = "A comprehensive ASP.NET Core MVC portfolio platform organizing project metadata and user links.",

            }
        };

        public static List<TumalaProject> GetProjects() => All;
    }
}