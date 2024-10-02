using Azure;
using ClassroomAssignment.Domain.Models;
using ClassroomAssignment.DomainServices;
using Microsoft.AspNetCore.Mvc;

namespace ClassroomAssignment.WebApi.Controllers
{
    [ApiController]
    [Route("api/StudentClass")]
    public class StudentClassController : ControllerBase
    {


        private readonly ILogger<StudentClassController> _logger;
        private readonly IStudentClassRepo _studentClassRepo;

        //Deze controller heeft geen seperation of concern
        public StudentClassController(ILogger<StudentClassController> logger, IStudentClassRepo studentClassRepo)
        {
            _logger = logger;
            _studentClassRepo = studentClassRepo;
        }

        [HttpGet]
        public IEnumerable<StudentClass> Get()
        {
            return _studentClassRepo.GetAll();
        }

        [HttpPost]
        public void Post(StudentClass studentClass)
        {
            throw new NotImplementedException();
        }

        [HttpPut]
        public OkResult Put()
        {
            return Ok();
        }

        [HttpDelete]
        public OkResult Delete()
        {
            return Ok();
        }

        [HttpGet]
        [Route("/StudentClass/{id}")]
        public StudentClass Get(Guid id)
        {
            return _studentClassRepo.GetById(id);
        }

        [HttpPut]
        [Route("/StudentClass/{id}")]
        public StudentClass UpdateStudentClass(Guid id)
        {
            return _studentClassRepo.GetById(id);
        }


        [HttpDelete]
        [Route("/StudentClass/{id}")]
        public StudentClass DeleteStudentClass(Guid id)
        {
            return _studentClassRepo.GetById(id);
        }


        [HttpGet]
        [Route("/StudentClass/{id}/Courses")]
        public StudentClass GetCoursesOfStudentClass(Guid id)
        {
            return _studentClassRepo.GetById(id);
        }

        [HttpPost]
        [Route("/StudentClass/{id}/Courses")]
        public StudentClass GetCoursesOfStudentClass(Guid id, Course course)
        {
            throw new NotImplementedException();
        }

    }
}
