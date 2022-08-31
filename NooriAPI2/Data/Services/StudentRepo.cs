using NooriAPI2.Data.Entity;
using NooriAPI2.Data.Interfaces;
using Microsoft.EntityFrameworkCore;
using NooriAPI2.Data.Context;

namespace NooriAPI2.Data.Services
{
    public class StudentRepo : IStudentRepo
    {
        private readonly SchoolDbContext _context;
        public StudentRepo(SchoolDbContext context)
        {
            _context = context;
        }

        public async Task<bool> Add(Student student)
        {
            await _context.Noori_Students.AddAsync(student);
            var result = _context.SaveChanges();
            return result > 0;
        }

        public async Task<bool> Delete(Student student)
        {
            _context.Noori_Students.Remove(student);
            var result = _context.SaveChanges();
            return result > 0;

        }

        public Task<bool> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Student> Get(int id)
        {
            var stud = await _context.Noori_Students.FirstOrDefaultAsync(x => x.Id == id);
            return stud;
        }

        public async Task<IEnumerable<Student>> GetAll()
        {
            var students = await _context.Noori_Students.ToListAsync();
            return students;
        }

        public Student Update(Student student)
        {
            var result = _context.Update(student);
            return result.Entity;
        }
    }
}
