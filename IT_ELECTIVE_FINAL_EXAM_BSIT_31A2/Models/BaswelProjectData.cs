using System.Collections.Generic;
namespace IT_ELECTIVE_FINAL_EXAM_BSIT_31A2.Models
{
    public static class BaswelProjectData
    {
        public static List<BaswelProject> All { get; } = new List<BaswelProject>
{
new BaswelProject {
Id = 1,
Title = "Midterm Activity 1 - Student Portfolio Web App",
Category = "Midterm",
GithubUrl = "https://github.com/BASWEL06/IT_ELECTIVE_2_Midterm_A1_Baswel_Constantino.git",
Description = "Responsive student portfolio web application.",
},
new BaswelProject {
Id = 2,
Title = "Bsit - Portfolio",
Category = "Midterm",
GithubUrl = "https://github.com/BASWEL06/IT-ELECTIVE-BSIT-PORTFOLIO.git",
Description = "Portfolio website for Constantino IV B. Baswel.",
},
new BaswelProject {
Id = 3,
Title = "Hackathon Project",
Category = "Midterm",
GithubUrl = "https://github.com/BASWEL06/IT-ELECTIVE_HACKATHON_BASWEL_CONSTANTINO.git",
Description = "Fitness tracking application.",
},
new BaswelProject {
Id = 4,
Title = "IT elective prefinal exam - student portfolio",
Category = "Prefinal",
GithubUrl = "https://github.com/BASWEL06/IT_ELECTIVE_2_BSIT31E2_PREFINAL_EXAM_BAswel_COnstantino.git",
Description = "A comprehensive ASP.NET Core MVC portfolio platform organizing project metadata and user links.",
},
new BaswelProject {
Id = 5,
Title = "YT System",
Category = "Pre-Finals",
GithubUrl = "https://github.com/BASWEL06/IT_ELECTIVE_BSIT_31E2_Baswel_Constantino.git",
Description = "System video presentation.",
}
};
        public static List<BaswelProject> GetProjects() => All;
    }
}