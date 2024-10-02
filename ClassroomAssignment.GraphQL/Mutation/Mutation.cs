using ClassroomAssignment.Domain.Models;
using ClassroomAssignment.DomainServices;

namespace ClassroomAssignment.GraphQL.Mutation;

public class Mutation(IStudentClassRepo studentClassRepo)
{
    public async Task<StudentClass> AddStudentClass(StudentClass studentClass)
    {
        return await studentClassRepo.AddAsync(studentClass);
        // Omitted code for brevity
    }

    public async Task<StudentClass> PublishStudentClass(StudentClass studentClass)
    {
        return await studentClassRepo.UpdateAsync(studentClass);
        // Omitted code for brevity
    }
}