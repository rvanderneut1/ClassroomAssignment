using ClassroomAssignment.Domain.Models;

namespace ClassroomAssignment.DomainServices
{
    public interface IStudentClassRepo
    {
        public IEnumerable<StudentClass> GetAll();

        public IQueryable<StudentClass> GetAllAsync();
            
        public StudentClass GetById(Guid id);
        public Task<StudentClass> GetByIdAsync(Guid id);

        public Task<StudentClass> AddAsync(StudentClass studentClass);
        public Task<StudentClass> UpdateAsync(StudentClass studentClass);



        public IEnumerable<Course> GetCoursesById(Guid id);


    }
}
