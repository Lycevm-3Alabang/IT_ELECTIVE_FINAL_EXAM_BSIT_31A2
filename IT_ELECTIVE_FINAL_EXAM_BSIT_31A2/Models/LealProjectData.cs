using System.Collections.Generic;

namespace IT_ELECTIVE_FINAL_EXAM_BSIT_31A2.Models
{
    public static class LealProjectData
    {
        public static LealProject GetPortfolioData()
        {
            return new LealProject
            {
                FullName = "Adrian M. Leal",
                Initials = "AL",
                CourseSection = "IT ELECTIVE 2 • BSIT31E2",

                Projects = new List<LealItem>
                {
                    new LealItem
                    {
                        Title = "BSIT 31E2 Preliminary Exam",
                        Description = "Preliminary Examination project for IT coursework.",
                        ThumbnailUrl = "/images/Leal/project1.jpg",
                        GithubUrl = "https://github.com/lealadrianm01-cmyk/IT_ELECTIVE_2_PRELIM_EXAM_LEAL_ADRIAN.git"
                    },

                    new LealItem
                    {
                        Title = "IT Elective 2 Midterms Quiz 2",
                        Description = "Midterm quiz project for IT Elective 2.",
                        ThumbnailUrl = "/images/Leal/project2.jpg",
                        GithubUrl = "https://github.com/lealadrianm01-cmyk/IT_ELECTIVE_2_MIDTERM_Leal_Adrian_QUIZ_2.git"
                    },

                    new LealItem
                    {
                        Title = "IT Elective 2 Midterm Exam 2",
                        Description = "Midterm examination project demonstrating web development concepts.",
                        ThumbnailUrl = "/images/Leal/project3.jpg",
                        GithubUrl = "https://github.com/lealadrianm01-cmyk/-IT_ELECTIVE_2_MIDTERM_EXAM_4_Leal.git"
                    },

                    new LealItem
                    {
                        Title = "IT Elective 2 Assignment 1",
                        Description = "Assignment project for IT Elective 2.",
                        ThumbnailUrl = "/images/Leal/project4.jpg",
                        GithubUrl = "https://github.com/lealadrianm01-cmyk/IT_ELECTIVE_2_PREFINALS_A1_LEAL_ADRIAN.git"
                    },

                    new LealItem
                    {
                        Title = "IT Elective 2 Prefinal Exam",
                        Description = "Assignment project for IT Elective 2.",
                        ThumbnailUrl = "/images/Leal/project4.jpg",
                        GithubUrl = "https://github.com/lealadrianm01-cmyk/IT_ELECTIVE_2_BSIT31E2_PREFINAL_EXAM_LEAL_ADRIAN_LEAL_M.-main.git"
                    },


                    new LealItem
                    {
                        Title = "Quiz Leal, Bueno, Puna",
                        Description = "Assignment project for IT Elective 2.",
                        ThumbnailUrl = "/images/Leal/project4.jpg",
                        GithubUrl = "https://github.com/lealadrianm01-cmyk/Quiz_Bueno_Leal_Puna.git"
                    }

                }
            };
        }
    }
}