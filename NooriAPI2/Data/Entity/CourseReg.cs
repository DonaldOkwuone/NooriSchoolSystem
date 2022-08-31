namespace NooriAPI2.Data.Entity
{
    public class CourseReg: BaseEntity
    {
        public int StudentId { get; set; }
        public int CourseId { get; set; }
        public IEnumerable<Student> Students { get; set; }
        public IEnumerable<Course> Courses { get; set; }
    }
}
