namespace IT_ELECTIVE_FINAL_EXAM_BSIT_31A2.Models
{
    public static class GeralinProjectData
    {
        public static List<GeralinProject> All { get; } = new List<GeralinProject>
        {
            new GeralinProject  
            {
                Id = 1,
                Title = "Hello World, Fizz Buzz",
                GithubUrl = "https://github.com/PINONG03/BSIT31E2_Prelim_A1_GeralinKhen",
                Description = "First preliminary quiz submission containing basic project structure and fundamental logic.",
                ThumbnailUrl = "/images/khen/1st.jpg"
            },
            new GeralinProject  
            {
                Id = 2,
                Title = "Transport Resolver Challenge",
                GithubUrl = "https://github.com/PINONG03/BSIT_31E1_PRELIM_Q1_GERALIN_KHE",
                Description = "An automated C# testing framework on .NET 9 evaluating polymorphic vehicle collection handling.",
                ThumbnailUrl = "/images/khen/1st.jpg"
            },
            new GeralinProject
            {
                Id = 3,
                Title = "HTTPSERVER",
                GithubUrl = "https://github.com/PINONG03/BSIT_31E1_PRELIM_A3_GERALIN_KHENGERALD.",
                Description = "Low-level C# project building a custom HTTP server from scratch to handle socket connections and raw HTTP requests.",
                ThumbnailUrl = "/images/khen/1st.jpg"
            },
            new GeralinProject
            {
                Id = 4,
                Title = "IT-ELECTIVE PRELIM EXAM",
                GithubUrl = "https://github.com/PINONG03/IT_ELECTIVE_2_PRELIM_EXAM_GERALIN_KHEN",
                Description = "Hands-on preliminary examination covering initial course learning modules and coding standards.",
                ThumbnailUrl = "/images/khen/1st.jpg"
            },
            new GeralinProject
            {
                Id = 5,
                Title = "Prelim Exam",
                GithubUrl = "https://github.com/PINONG03/IT_ELECTIVE_2_Assignment_GERALIN",
                Description = "Initial preliminary course assignment focusing on basic project setups and algorithmic logic.",
                ThumbnailUrl = "/images/khen/1st.jpg"
            },
            new GeralinProject
            {
                Id = 6,
                Title = "Portfolio",
                GithubUrl = "https://github.com/PINONG03/IT_ELECTIVE_BSIT_31E2_PORTFOLIO_GERALIN_KHEN",
                Description = "Portfolio for me",
                ThumbnailUrl = "/images/khen/1st.jpg"
            }
        };
    }
}