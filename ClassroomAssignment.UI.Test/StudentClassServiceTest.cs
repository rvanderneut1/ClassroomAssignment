using ClassroomAssignment.Domain.Models;
using ClassroomAssignment.DomainServices;
using ClassroomAssignment.Infrastructure;
using NSubstitute;

namespace ClassroomAssignment.UI.Test
{
    public class StudentClassService
    {
        [Fact]
        public void Class_Has_1_Student()
        {
            //arrange
            var studentClassRepo = NSubstitute.Substitute.For<IStudentClassRepo>();

            studentClassRepo.GetById(new Guid("85a852c3-508f-4aec-9273-4d59242d7238")).Returns(new StudentClass()
            {
                Id = new Guid("85a852c3-508f-4aec-9273-4d59242d7238"),
                Name = "Class 1",
                Students = new List<Student>() { new() { Name = "jan" } },
                Courses = new List<Course>()
            });
            var studentClassService = new UI.StudentClassService(studentClassRepo);

            //act
            var classes = studentClassService.GetStudentCount(new Guid("85a852c3-508f-4aec-9273-4d59242d7238"));

            //assert

            Assert.Equal(1, classes);

        }
    }
}