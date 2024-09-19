using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassroomAssignment.Domain.Models
{
    public class Student
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public string StudentId { get; set; }

        public StudentClass StudentClass { get; set; }

    }
}
