namespace IT_ELECTIVE_FINAL_EXAM_BSIT_31A2.Models
{
    public class LealItem
    {
        public string Title { get; set; } = "";
        public string Description { get; set; } = "";
        public string ThumbnailUrl { get; set; } = "";
        public string GithubUrl { get; set; } = "";
    }

    public class LealProject
    {
        public string FullName { get; set; } = "";
        public string Initials { get; set; } = "";
        public string CourseSection { get; set; } = "";
        public List<LealItem> Projects { get; set; } = new();
    }
}
