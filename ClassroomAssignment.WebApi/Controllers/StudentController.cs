using ClassroomAssignment.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ClassroomAssignment.WebApi.Controllers
{
    [Route("api/Students")]
    [ApiController]
    public class StudentController : ControllerBase
    {

        [HttpGet]
        public IEnumerable<Student> GetStudents()
        {
            throw new NotImplementedException();
        }

        [HttpGet]
        [Route("api/Students/{id}")]
        public Student GetStudent(int id)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public void PostStudent(Student student)
        {
            throw new NotImplementedException();
        }

        [HttpPut]
        [Route("api/Students/{id}")]
        public void PutStudent(int id, Student student)
        {
            throw new NotImplementedException();
        }

        [HttpDelete]
        [Route("api/Students/{id}")]
        public void DeleteStudent(int id, Student student)
        {
            throw new NotImplementedException();
        }
    }


}
