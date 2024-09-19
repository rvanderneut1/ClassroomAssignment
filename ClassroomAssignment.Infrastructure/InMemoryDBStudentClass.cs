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
                Id = Guid.NewGuid(), Name = "Class 1", Students = new List<Student>(), Courses = new List<Course>()
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

        public StudentClass GetById(Guid id)
        {
            return StudentsClass.FirstOrDefault(x => x.Id == id);
        }
    }
}
