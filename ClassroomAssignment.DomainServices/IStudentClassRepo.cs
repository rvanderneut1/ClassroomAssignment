using ClassroomAssignment.Domain.Models;

namespace ClassroomAssignment.DomainServices
{
    public interface IStudentClassRepo
    {
        public IEnumerable<StudentClass> GetAll();

        public StudentClass GetById(Guid id);
    }
}
