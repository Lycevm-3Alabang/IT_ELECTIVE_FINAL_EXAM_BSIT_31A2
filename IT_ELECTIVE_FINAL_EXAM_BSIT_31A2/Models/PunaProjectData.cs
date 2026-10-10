using System.Collections.Generic;

namespace IT_ELECTIVE_FINAL_EXAM_BSIT_31A2.Models
{
    public static class PunaProjectData
    {
        public static PunaProject GetPortfolioData()
        {
            return new PunaProject
            {
                FullName = "Deejay Khryll Puna",
                Initials = "DP",
                CourseSection = "IT ELECTIVE 2 • BSIT31E2",

                Projects = new List<PunaItem>
                {
                    new PunaItem
                    {
                        Title = "BSIT 31E2 Preliminary Quiz 1",
                        Description = "Preliminary quiz project for IT coursework.",
                        ThumbnailUrl = "/images/Puna/project1.jpg",
                        GithubUrl = "https://github.com/Deejay0420/BSIT31E2_PRELIM_Q1_PUNA_DEEJAY-KHRYLL"
                    },

                    new PunaItem
                    {
                        Title = "IT Elective 2 Midterms Quiz 2",
                        Description = "Midterm quiz project for IT Elective 2.",
                        ThumbnailUrl = "/images/Puna/project2.jpg",
                        GithubUrl = "https://github.com/Deejay0420/IT_ELECTIVE_2_MIDTERM_Q2_Puna_DeejayKhryll"
                    },

                    new PunaItem
                    {
                        Title = "IT Elective 2 Midterm Exam 2",
                        Description = "Midterm examination project demonstrating web development concepts.",
                        ThumbnailUrl = "/images/Puna/project3.jpg",
                        GithubUrl = "https://github.com/Deejay0420/IT_ELECTIVE_2_MIDTERM_EXAM_12_Puna"
                    },

                    new PunaItem
                    {
                        Title = "IT Elective 2 Assignment 1",
                        Description = "Assignment project for IT Elective 2.",
                        ThumbnailUrl = "/images/Puna/project4.jpg",
                        GithubUrl = "https://github.com/Deejay0420/IT_ELECTIVE_2_A1_Puna_DeejayKhryll"
                    }
                }
            };
        }
    }
}