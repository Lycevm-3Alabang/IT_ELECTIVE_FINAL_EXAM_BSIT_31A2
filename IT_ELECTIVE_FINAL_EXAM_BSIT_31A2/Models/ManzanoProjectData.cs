using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace IT_ELECTIVE_FINAL_EXAM_BSIT_31A2.Models
{
    public class ManzanoProjectData
    {
        public static List<ManzanoProject> All { get; } = new List<ManzanoProject>
    {
        new ManzanoProject
        {
            Id = 1,
            Title = "BSIT31E2_PRELIM_A1_MANZANO_ALEJANDRO",
            Description = "We do the FizzBuzz algorithm by outputting numbers and conditional text based on divisibility rules.",
            GithubUrl = "https://github.com/andrewmanzano/BSIT31E2_PRELIM_A1_MANZANO_ALEJANDRO.git",
            ThumbnailUrl = "/images/Manzano/A1.png"
        },

        new ManzanoProject
        {
            Id = 2,
            Title = "BSIT31E2_PRELIM_A2_Manzano_Alejandro",
            Description = "A simple project that performs basic math operations like addition, subtraction, multiplication, and division.",
            GithubUrl = "https://github.com/andrewmanzano/BSIT31E2_PRELIM_A2_Manzano_Alejandro.git",
            ThumbnailUrl = "/images/Manzano/A2.png"
        },

        new ManzanoProject
        {
            Id = 3,
            Title = "BSIT31E2_PRELIM_H1_MANZANO_ALEJANDRO",
            Description = "A menu-driven terminal tool built to track student profiles, record academic marks, and analyze performance metrics.",
            GithubUrl = "https://github.com/andrewmanzano/BSIT31E2_PRELIM_H1_MANZANO_ALEJANDRO.git",
            ThumbnailUrl = "/images/Manzano/H1.png"
        },

        new ManzanoProject
        {
            Id = 4,
            Title = "BSIT31E2_PRELIM_H2_MANZANO_ALEJANDRO",
            Description = "Not done yet",
            GithubUrl = "https://github.com/andrewmanzano/BSIT31E2_PRELIM_H2_MANZANO_ALEJANDRO.git",
            //ThumbnailUrl = "/images/Manzano/H2.png"
		},

        new ManzanoProject
        {
            Id = 5,
            Title = "BSIT_31E2_PRELIM_Q1_Manzano_Alejandro",
            Description = "An object-oriented unit testing suite that verifies vehicle inheritance, interface implementations, and polymorphic factory behaviors.",
            GithubUrl = "https://github.com/andrewmanzano/BSIT_31E2_PRELIM_Q1_Manzano_Alejandro.git",
            ThumbnailUrl = "/images/Manzano/Q1.png"
        },

        new ManzanoProject
        {
            Id = 6,
            Title = "BSIT-31E2-PRELIM-A3-MANZANO-ALEJANDRO",
            Description = "A client that sends HTTP requests to REST APIs and formats fetched JSON payload responses.",
            GithubUrl = "https://github.com/andrewmanzano/BSIT-31E2-PRELIM-A3-MANZANO-ALEJANDRO.git",
            ThumbnailUrl = "/images/Manzano/A3.png"
        },

        new ManzanoProject
        {
            Id = 7,
            Title = "IT-ELECTIVE-2-PRELIM-EXAM-MANZANO-ALEJANDRO",
            Description = "A hands-on coding examination designed to test C# mastery by writing code solutions to fulfill automated test specifications and score points.",
            GithubUrl = "https://github.com/andrewmanzano/IT-ELECTIVE-2-PRELIM-EXAM-MANZANO-ALEJANDRO.git",
            ThumbnailUrl = "/images/Manzano/Prelim-Exam.png"
        },

        new ManzanoProject
        {
            Id = 8,
            Title = "IT_ELECTIVE_2_Midterm_A1_Manzano_Alejandro",
            Description = "A clean, responsive web application presenting personal software development achievements, background information, and skills.",
            GithubUrl = "https://github.com/andrewmanzano/IT_ELECTIVE_2_Midterm_A1_Manzano_Alejandro.git",
            ThumbnailUrl = "/images/Manzano/MA1.png"
        },

        new ManzanoProject
        {
            Id = 9,
            Title = "-IT_ELECTIVE_BSIT_31E2_-MANZANO_ALEJANDRO-",
            Description = "A web application implementing secure user authentication and landing page redirection.",
            GithubUrl = "https://github.com/andrewmanzano/-IT_ELECTIVE_BSIT_31E2_-MANZANO_ALEJANDRO-.git",
            ThumbnailUrl = "/images/Manzano/Simple_login_page.png"
        },

        new ManzanoProject
        {
            Id = 10,
            Title = "IT_ELECTIVE_2_MIDTERM_Q2_MANZANO_ALEAJNDRO",
            Description = "A web application designed to manage, organize, and play music playlists, protected by a user authentication.",
            GithubUrl = "https://github.com/andrewmanzano/IT_ELECTIVE_2_MIDTERM_Q2_MANZANO_ALEAJNDRO.git",
            ThumbnailUrl = "/images/Manzano/MQ2.png"
        },

        new ManzanoProject
        {
            Id = 11,
            Title = "IT_ELECTIVE_2_MIDTERM_H1_H2_H3_MANZANO_ALEJANDRO",
            Description = "A product catalog and POS system featuring item listings, shopping cart updates, and price calculations.",
            GithubUrl = "https://github.com/andrewmanzano/IT_ELECTIVE_2_MIDTERM_H1_H2_H3_MANZANO_ALEJANDRO.git",
            ThumbnailUrl = "/images/Manzano/MH1_H2_H3.png"
        },

        new ManzanoProject
        {
            Id = 12,
            Title = "IT_ELECTIVE_2_MIDTERM_EXAM_8_Manzano_Alejandro",
            Description = "A conference management dashboard built to register attendees, track check-in status, and monitor event participant details.",
            GithubUrl = "https://github.com/andrewmanzano/IT_ELECTIVE_2_MIDTERM_EXAM_8_Manzano_Alejandro.git",
            ThumbnailUrl = "/images/Manzano/M_E_8.png"
        },

        new ManzanoProject
        {
            Id = 13,
            Title = "IT_ELECTIVE_2_MIDTERM_Q3_Manzano_Alejandro",
            Description = "A secure login authentication system featuring attempt tracking up to 3 attempts, remaining try alerts, and account lockout protections.",
            GithubUrl = "https://github.com/andrewmanzano/IT_ELECTIVE_2_MIDTERM_Q3_Manzano_Alejandro.git",
            ThumbnailUrl = "/images/Manzano/M_Q3.png"
        },

        new ManzanoProject

        {
            Id = 14,
            Title = "Manzano-Prefinal-Activity",
            Description = "An ASP.NET Core Identity authentication portal supporting local user accounts, registration, password recovery, and external login integrations.",
            GithubUrl = "https://github.com/andrewmanzano/Manzano-Prefinal-Activity.git",
            ThumbnailUrl = "/images/Manzano/PreFinal_Act.png"
        },

        new ManzanoProject
        {
            Id = 15,
            Title = "IT_ELECTIVE_2_BSIT-31E2_PREFINAL_EXAM_Manzano_Alejandro",
            Description = "A web application built as a practical exam where multiple-choice questions, options, and selected answers are dynamically rendered on-screen.",
            GithubUrl = "https://github.com/andrewmanzano/IT_ELECTIVE_2_BSIT-31E2_PREFINAL_EXAM_Manzano_Alejandro.git",
            ThumbnailUrl = "/images/Manzano/PreFinal_Exam.png"
        },
        };
    }
}
