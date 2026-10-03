using System.Collections.Generic;

namespace IT_ELECTIVE_FINAL_EXAM_BSIT_31A2.Models
{
    public class ManzanoProject
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;

        public string ShortDescription { get; set; } = string.Empty;

        public string DetailedDescription { get; set; } = string.Empty;

        public string GitHubUrl { get; set; } = string.Empty;

        public string ThumbnailPath { get; set; } = string.Empty;

        public List<string> Technologies { get; set; } = new();

    }
}