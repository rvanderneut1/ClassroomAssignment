using System.Linq.Expressions;
using ClassroomAssignment.Domain.Models;
using ClassroomAssignment.DomainServices;
using Microsoft.EntityFrameworkCore;

namespace ClassroomAssignment.Infrastructure
{
    public class StudentClassRepository(ClassroomAssignmentDBContext classroomAssignmentDbContext) :  IStudentClassRepo
    {


        public IEnumerable<StudentClass> GetAll()
        {
            return classroomAssignmentDbContext.StudentClasses;
        }

        public IQueryable<StudentClass> GetAllAsync()
        {
            return classroomAssignmentDbContext.StudentClasses.Include(m=>m.Students).AsQueryable();
        }

        public StudentClass GetById(Guid id)
        {
            return classroomAssignmentDbContext.StudentClasses.Include(s => s.Students).FirstOrDefault(x => x.Id == id);
        }

        public Task<StudentClass> GetByIdAsync(Guid id)
        {
            return classroomAssignmentDbContext.StudentClasses.Include(s => s.Students).FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<StudentClass> AddAsync(StudentClass studentClass)
        {

            var result = await classroomAssignmentDbContext.AddAsync(studentClass);
            await classroomAssignmentDbContext.SaveChangesAsync();
            return result.Entity;
        }

        public async Task<StudentClass> UpdateAsync(StudentClass studentClass)
        {
            var studentClassUpdate = await classroomAssignmentDbContext.StudentClasses.FirstOrDefaultAsync(m => m.Id == studentClass.Id)  ;
            try
            {
                studentClassUpdate.Name = studentClass.Name;


                await classroomAssignmentDbContext.SaveChangesAsync();
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }

            return studentClassUpdate ?? null;
        }

        public IEnumerable<Course> GetCoursesById(Guid id)
        {
            return classroomAssignmentDbContext.StudentClasses.Include(x => x.Courses).FirstOrDefault(x => x.Id == id).Courses;
        }

        //public async Task<StudentClass> AddAsync(StudentClass studentclass)
        //{
        //   var result =  await classroomAssignmentDbContext.AddAsync(studentclass);
        //   await classroomAssignmentDbContext.SaveChangesAsync();
        //   return result.Entity;
        //}
    }
}
