using ClassroomAssignment.DomainServices;

namespace ClassroomAssignment.UI
{
    public class StudentClassService(IStudentClassRepo studentClassRepo) : IStudentClassService
    {
        public int GetStudentCount(Guid classId)
        {
            return studentClassRepo.GetById(classId)  .Students.Count();
        }
    }
}
