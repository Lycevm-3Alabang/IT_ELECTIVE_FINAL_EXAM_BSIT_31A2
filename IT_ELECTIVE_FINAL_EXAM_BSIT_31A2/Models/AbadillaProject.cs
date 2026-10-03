namespace IT_ELECTIVE_FINAL_EXAM_BSIT_31A2.Models
{
    public class ProjectItem
    {
        public string Title { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string ThumbnailUrl { get; set; } = string.Empty;
        public string GithubUrl { get; set; } = string.Empty;
    }

    public class AbadillaProject
    {
        public string FullName { get; set; } = string.Empty;
        public string Initials { get; set; } = string.Empty;
        public string CourseSection { get; set; } = string.Empty;
        public List<ProjectItem> Projects { get; set; } = new();
    }
}