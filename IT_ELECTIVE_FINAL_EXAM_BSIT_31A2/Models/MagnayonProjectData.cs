using System.Collections.Generic;

namespace IT_ELECTIVE_FINAL_EXAM_BSIT_31A2.Models
{
    public static class MagnayonProjectData
    {
        public static List<MagnayonProject> GetProjects()
    {
        return new List<MagnayonProject>
            {
                new MagnayonProject
                {
                    Title = "The Icon Lounge",
                    Description = "A visual novel game exploring where your icons hang out while you aren't playing Geometry Dash.",
                    Technologies = "Ren'Py, Python",
                    ImageUrl = "~/images/magnayon/iconlounge_icon.png",
                    ProjectUrl = "https://yuuworks.itch.io/the-icon-lounge"
                },
                new MagnayonProject
                {
                    Title = "Phoolish PHIGHTING Pack!",
                    Description = "A creative, custom Joker mod pack developed for the popular roguelike deckbuilder game, Balatro.",
                    Technologies = "Lua, Love2D",
                    ImageUrl = "~/images/magnayon/PhoolishPhightingPack_Logo.png",
                    ProjectUrl = "https://balatromods.miraheze.org/wiki/Phoolish_PHIGHTING_Pack!"
                },
                new MagnayonProject
                {
                    Title = "Neocities Web Dev",
                    Description = "Freelance custom website design and development commissions for various clients on Neocities.",
                    Technologies = "HTML, CSS, JavaScript",
                    ImageUrl = "~/images/magnayon/Neocities_Logo.svg.webp",
                    ProjectUrl = "https://neocities.org/"
                }
            };
        }
    }
}