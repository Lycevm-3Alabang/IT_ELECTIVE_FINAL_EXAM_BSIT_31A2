namespace IT_ELECTIVE_FINAL_EXAM_BSIT_31A2.Models
{
    public class TumalaProject
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Category { get; set; } = string.Empty;
        public string GithubUrl { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;

        public string ThumbnailUrl { get; set; } = string.Empty;
    }
}