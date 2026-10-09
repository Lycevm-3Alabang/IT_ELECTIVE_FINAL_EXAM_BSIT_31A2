
namespace IT_ELECTIVE_FINAL_EXAM_BSIT_31A2.Models
{
    public static class BuenoProjectData
    {
        public static BuenoProject GetPortfolioData()
        {
            return new BuenoProject
            {
                FullName = "Paul Xander Bueno",
                Initials = "PB",
                CourseSection = "IT ELECTIVE 2 • BSIT31E2",

                Projects = new List<BuenoItem>
                {
                    new BuenoItem
                    {
                        Title = "BSIT_31E2_PRELIM_Q1_Bueno_Paul-Xander",
                        Description = "ASP.NET Core MVC project developed for the IT Elective 2 preliminary examination.",
                        ThumbnailUrl = "/images/Bueno/project1.jpg",
                        GithubUrl = "https://github.com/andeybueno-cpu/BSIT_31E2_PRELIM_Q1_Bueno_Paul-Xander.git"
                    },

                    new BuenoItem
                    {
                        Title = "IT_ELECTIVE_2_MIDTERMS_Q2_Bueno_PaulXander",
                        Description = "ASP.NET Core MVC project developed for the IT Elective 2 midterm coursework.",
                        ThumbnailUrl = "/images/Bueno/project2.jpg",
                        GithubUrl = "https://github.com/andeybueno-cpu/IT_ELECTIVE_2_MIDTERMS_Q2_Bueno_PaulXander.git"
                    },

                    new BuenoItem
                    {
                        Title = "IT_ELECTIVE_2_MIDTERM_EXAM_2_Bueno",
                        Description = "IT Elective 2 midterm examination project demonstrating web development concepts.",
                        ThumbnailUrl = "/images/Bueno/project3.jpg",
                        GithubUrl = "https://github.com/andeybueno-cpu/IT_ELECTIVE_2_MIDTERM_EXAM_2_Bueno.git"
                    },

                    new BuenoItem
                    {
                        Title = "IT_ELECTIVE_2_BSIT_31E2_PREFINAL_EXAM_Bueno_Paul",
                        Description = "ASP.NET Core MVC project developed for the IT Elective 2 prefinal examination.",
                        ThumbnailUrl = "/images/Bueno/project4.jpg",
                        GithubUrl = "https://github.com/andeybueno-cpu/-IT_ELECTIVE_2_BSIT_31E2_PREFINAL_EXAM_Bueno_Paul.git"
                    },

                    new BuenoItem
                    {
                        Title = "BSIT_31E2_PORTFOLIO_BUENO",
                        Description = "Student portfolio project showcasing IT Elective 2 web development work.",
                        ThumbnailUrl = "/images/Bueno/project5.jpg",
                        GithubUrl = "https://github.com/andeybueno-cpu/BSIT_31E2_PORTFOLIO_BUENO.git"
                    }
                }
            };
        }
    }
}
