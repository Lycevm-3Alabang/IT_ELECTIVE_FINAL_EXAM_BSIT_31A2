using System.Collections.Generic;

namespace IT_ELECTIVE_FINAL_EXAM_BSIT_31A2.Models
{
    public static class LlorenteProjectData
    {
        public static List<LlorenteProject> All { get; } = new List<LlorenteProject>
        {
            new LlorenteProject
            {
                Id = 1,
                Title = "Prelim Activity 1 - FizzBuzz Algorithm Application",
                Category = "Prelim",
                GithubUrl = "https://github.com/Laurencellorente/BSIT31E2_Prelim_A1_LaurenceLlorente.git",
                Description = "A C# console application evaluating FizzBuzz algorithm logic.",
                ThumbnailUrl = "/images/Llorente/coding.jpeg"
            },
            new LlorenteProject
            {
                Id = 2,
                Title = "Prelim Activity 2 - Student Management Portal",
                Category = "Prelim",
                GithubUrl = "https://github.com/Laurencellorente/BSIT31E2_Prelim_A2_LaurenceLlorente.git",
                Description = "A BSIT web application built for academic course tracking and student data handling.",
                ThumbnailUrl = "/images/Llorente/coding.jpeg"
            },
            new LlorenteProject
            {
                Id = 3,
                Title = "Midterm Activity 1 - Student Portfolio Web App",
                Category = "Midterm",
                GithubUrl = "https://github.com/Laurencellorente/IT_ELECTIVE_2_Midterm_A1_Llorente_Laurence.git",
                Description = "A responsive ASP.NET Core MVC web application serving as a student portfolio landing page.",
                ThumbnailUrl = "/images/Llorente/coding.jpeg"
            },
            new LlorenteProject
            {
                Id = 4,
                Title = "Monochrome POS System",
                Category = "Midterm",
                GithubUrl = "https://github.com/Laurencellorente/IT_ELECTIVE_2_MIDTERM_H1_H2_H3_LLORENTE_BSIT_31E2.git",
                Description = "A full-stack black-and-white ASP.NET Core MVC Point of Sale application formatted in PHP currency.",
                ThumbnailUrl = "/images/Llorente/coding.jpeg"
            },
            new LlorenteProject
            {
                Id = 5,
                Title = "IT Support Ticketing Operations System",
                Category = "Pre-Finals",
                GithubUrl = "https://github.com/Laurencellorente/Project_Llorente_Daygon_Solomon.git",
                Description = "A live monitoring operations dashboard for managing IT support ticket statuses and team workflows.",
                ThumbnailUrl = "/images/Llorente/coding.jpeg"
            },
            new LlorenteProject
            {
                Id = 6,
                Title = "IT Elective PreFinal Exam - Student Portfolio Portal",
                Category = "Finals",
                GithubUrl = "https://github.com/Laurencellorente/IT_ELECTIVE_2_-31E2-_PREFINAL_EXAM_Llorente_Laurence.git",
                Description = "A comprehensive ASP.NET Core MVC portfolio platform organizing project metadata and user links.",
                ThumbnailUrl = "/images/Llorente/coding.jpeg"
            }
        };

        public static List<LlorenteProject> GetProjects() => All;
    }
}