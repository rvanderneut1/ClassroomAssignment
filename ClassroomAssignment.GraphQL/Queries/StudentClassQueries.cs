using ClassroomAssignment.Domain.Models;
using ClassroomAssignment.DomainServices;

namespace ClassroomAssignment.GraphQL.Queries;

public class StudentClassQueries()
{
    public IEnumerable<StudentClass> GetStudentClasses([Service] IStudentClassRepo _studentClassRepo) => _studentClassRepo.GetAllAsync();
    public async Task<StudentClass> GetStudentClass([Service] IStudentClassRepo _studentClassRepo, Guid id) => await _studentClassRepo.GetByIdAsync(id);

}