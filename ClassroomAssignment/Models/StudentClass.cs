namespace ClassroomAssignment.Domain.Models
{
  
    public class StudentClass
    {
        public Guid Id { get; set; }
        public required string Name { get; set; }

        public ICollection<Student> Students { get; set; } = new List<Student>();

        public ICollection<Course> Courses { get; set; } = new List<Course>();
    }
}
