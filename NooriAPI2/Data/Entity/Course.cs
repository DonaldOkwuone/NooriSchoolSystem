namespace NooriAPI2.Data.Entity
{
    public class Course
    {
        public int Id { get; set; }
        public string? CourseName { get; set; }
        public string? CourseLecturer { get; set; }
        public DateTime DateAdded { get; set; }
        public DateTime DateUpdated { get; set; }
    }
}
