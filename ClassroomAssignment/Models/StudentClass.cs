namespace ClassroomAssignment.Domain.Models
{
    public class StudentClass
    {
        public Guid Id { get; set; }
        public string Name { get; set; }

        public ICollection<Student> Students { get; set; }

        public ICollection<Course> Courses { get; set; }
    }
}
