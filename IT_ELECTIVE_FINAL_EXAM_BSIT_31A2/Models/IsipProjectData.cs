namespace IT_ELECTIVE_FINAL_EXAM_BSIT_31A2.Models
{
    public static class IsipProjectData
    {
        public static List<IsipProject> All { get; } = new List<IsipProject>
        {
            new IsipProject
            {
                Id = 1,
                Title = "Draft Portfolio",
                GithubUrl = "https://github.com/R3n3n/IT_ELECTIVE_2_Midterm_A1_Isip_Renen",
                Description = "A practice portfolio using Razor views and Bootstrap.",
                ThumbnailUrl = "/images/isip/midterm-portfolio.png"
            },
            new IsipProject
            {
                Id = 2,
                Title = "Ppop Store POS",
                GithubUrl = "https://github.com/R3n3n/IT_ELECTIVE_2_MIDTERM_H1_H2_H3_Isip_Renen",
                Description = "A practice website imitating the 16Personalities test. Returns an actual result based on your answers.",
                ThumbnailUrl = "/images/isip/ppop-store-pos.png"
            },
            new IsipProject
            {
                Id = 3,
                Title = "Playlist App",
                GithubUrl = "https://github.com/R3n3n/IT_ELECTIVE_2_MIDTERM_Q2_Isip_Renen",
                Description = "A simple login simulation using MVC model binding and data annotations to validate input.",
                ThumbnailUrl = "/images/isip/playlist-app.png"
            },
            new IsipProject
            {
                Id = 4,
                Title = "Lab Monitoring System",
                GithubUrl = "https://github.com/R3n3n/IT_ELECTIVE_2_MIDTERM_EXAM_SET4_ISIP_RENEN",
                Description = "A simple YouTube playlist builder web application using DTOs.",
                ThumbnailUrl = "/images/isip/lab-monitoring-system.png"
            },
            new IsipProject
            {
                Id = 5,
                Title = "Help Desk System",
                GithubUrl = "https://github.com/R3n3n/IT_ELECTIVE_PREFINALS_PROJECT",
                Description = "A web system used to register, log in, and monitor customer vehicles from check-in until release.",
                ThumbnailUrl = "/images/isip/prefinals-group-project.png"
            },
            new IsipProject
            {
                Id = 6,
                Title = "Prefinal Answer Booklet",
                GithubUrl = "https://github.com/R3n3n/IT_ELECTIVE_2_BSIT31E2_PREFINAL_EXAM_Isip_Renen",
                Description = "A web-based Point of Sale application for cashiers at a retro gaming shop — browse items, build a cart, update quantities, checkout, and review past sales receipts.",
                ThumbnailUrl = "/images/isip/prefinal-answer-booklet.png"
            },
        };
    }
}
