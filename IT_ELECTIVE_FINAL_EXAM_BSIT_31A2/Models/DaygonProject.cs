namespace IT_ELECTIVE_FINAL_EXAM_BSIT_31A2.Models
{
    public class DaygonProject
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string ShortDescription { get; set; } = string.Empty;
        public string DetailedDescription { get; set; } = string.Empty;
        public string GithubUrl { get; set; } = string.Empty;
        public string ImageUrl { get; set; } = string.Empty;
    }
}