using System.Linq.Expressions;
using ClassroomAssignment.Domain.Models;
using ClassroomAssignment.DomainServices;

namespace ClassroomAssignment.Infrastructure
{
    public class InMemoryDBStudentClass :  IStudentClassRepo
    {
        public List<StudentClass> StudentsClass { get; set; } = new List<StudentClass>()
        {
            new()
            {
                Id = new Guid("85a852c3-508f-4aec-9273-4d59242d7238"), Name = "Class 1", Students = new List<Student>() {new(){ Name = "jan"}}, Courses = new List<Course>()
            },
            new()
            {
                Id = Guid.NewGuid(), Name = "Class 2", Students = new List<Student>(), Courses = new List<Course>()
            }

        };


        public IEnumerable<StudentClass> GetAll()
        {
            return StudentsClass;
        }

        public IQueryable<StudentClass> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public StudentClass GetById(Guid id)
        {
            return StudentsClass.FirstOrDefault(x => x.Id == id);
        }

        public Task<StudentClass> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<StudentClass> UpdateAsync(StudentClass studentClass)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Course> GetCoursesById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<StudentClass> AddAsync(StudentClass studentclass)
        {
            throw new NotImplementedException();
        }
    }
}
