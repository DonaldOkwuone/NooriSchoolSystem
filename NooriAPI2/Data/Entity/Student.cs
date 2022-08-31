namespace NooriAPI2.Data.Entity
{
    public class Student : BaseEntity
    {
        public string?  FirstName { get; set; }
        public string?  LastName { get; set; }
        public string?  Password { get; set; }
        public string?  Email { get; set; }
        public DateTime?  DOB { get; set; }
        public int DepartmentId { get; set; }

        public IEnumerable<Department> departments { get; set; }
         
    }
}
