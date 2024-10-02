using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace ClassroomAssignment.Domain.Models
{
    [Index(nameof(StudentId), IsUnique = true)]
    public class Student
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }


        public string StudentId { get; set; }

        public StudentClass? StudentClass { get; set; }

        public Adress? Adress { get; set; }
    }
}
