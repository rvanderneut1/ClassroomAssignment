using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassroomAssignment.Domain.Models;
using ClassroomAssignment.DomainServices;

namespace ClassroomAssignment.Infrastructure
{
    internal class Fake : IStudentClassRepo
    {
        public IEnumerable<StudentClass> GetAll()
        {
            throw new NotImplementedException();
        }

        public IQueryable<StudentClass> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public StudentClass GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<StudentClass> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<StudentClass> AddAsync(StudentClass studentClass)
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
    }
}
