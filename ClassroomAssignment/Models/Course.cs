using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomAssignment.Domain.Models
{
    public class Course
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public int NumberOfLessons { get; set; }

        public bool HasExam { get; set; }

        public required StudentClass StudentClass { get; set; }
    }
}
