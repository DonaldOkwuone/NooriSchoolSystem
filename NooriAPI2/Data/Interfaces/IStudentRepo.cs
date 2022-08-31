using NooriAPI2.Data.Entity;
using System.Collections.Generic;

namespace NooriAPI2.Data.Interfaces
{
    public interface IStudentRepo
    {
        public Task<IEnumerable<Student>> GetAll();
        public Task<Student> Get(int id);

        public Student Update(Student student);

        public Task<bool> Delete(int id);

        public Task<bool> Add(Student student);
    }
}
