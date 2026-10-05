namespace IT_ELECTIVE_FINAL_EXAM_BSIT_31A2.Models
{
    public static class GeligProjectData
    {
        public static GeligProject GetPortfolioData()
        {
            return new GeligProject
            {
                FullName = "Kate Nicole Gelig",
                Initials = "KG",
                CourseSection = "IT ELECTIVE 2 • BSIT31A2",
                Projects = new List<GeligItem>
                {
                    new GeligItem
                    {
                        Title = "IT Elective Prefinals Project",
                        Description = "ASP.NET Core MVC application developed for the Prefinal project milestone.",
                        ThumbnailUrl = "/images/Gelig/project1.jpg",
                        GithubUrl = "https://github.com/abadillacjoaquin-coder/IT_ELECTIVE_PREFINALS_PROJECT.git"
                    },
                    new GeligItem
                    {
                        Title = "IT Elective 2 Prefinal Exam",
                        Description = "Prefinal examination codebase for BSIT 31E2 featuring MVC design patterns.",
                        ThumbnailUrl = "/images/Gelig/project2.jpg",
                        GithubUrl = "https://github.com/match4ulala/IT_ELECTIVE_2_-BSIT31E2-_PREFINAL_EXAM_GElig_KateNicole.git"
                    },
                    new GeligItem
                    {
                        Title = "IT Elective 2 Midterm Exam 9",
                        Description = "Midterm examination project executing core web architecture concepts.",
                        ThumbnailUrl = "/images/Gelig/project3.jpg",
                        GithubUrl = "https://github.com/match4ulala/-IT_ELECTIVE_2_MIDTERM_EXAM_9_Kate_Nicole_Gelig.git"
                    },
                    new GeligItem
                    {
                        Title = "Server Backend Application",
                        Description = "Core server repository managing backend services and data structures.",
                        ThumbnailUrl = "/images/Gelig/project4.jpg",
                        GithubUrl = "https://github.com/match4ulala/SERVER.git"
                    },
                    new GeligItem
                    {
                        Title = "IT Elective 2 Midterm 31E2",
                        Description = "Midterm coursework solution demonstrating structured MVC controller logic.",
                        ThumbnailUrl = "/images/Gelig/project5.jpg",
                        GithubUrl = "https://github.com/match4ulala/IT_ELECTIVE_2_Midterm_31E2_Gelig_Kate_Nicole.git"
                    },
                    new GeligItem
                    {
                        Title = "IT Elective 2 Midterm Quiz 2",
                        Description = "Assessment project focused on dynamic data rendering and validation.",
                        ThumbnailUrl = "/images/Gelig/project6.jpg",
                        GithubUrl = "https://github.com/match4ulala/IT_ELECTIVE_2_MIDTERM_Q2_Gelig_Kate_Nicole.git"
                    }
                }
            };
        }
    }
}