using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassroomAssignment.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace ClassroomAssignment.Infrastructure
{
    public class ClassroomAssignmentDBContext : DbContext
    {
        public ClassroomAssignmentDBContext(DbContextOptions<ClassroomAssignmentDBContext> options) : base(options)
        {
        }

        public DbSet<Student> Students { get; set; }
        public DbSet<StudentClass> StudentClasses { get; set; }

        //test seed data
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Student>().ToTable("Student");
            modelBuilder.Entity<StudentClass>().ToTable("StudentClass");

            //List<Student> students = new List<Student>
            //{
            //    new Student { Id = new Guid("54f2f515-54a1-454a-9585-54a1454a9587"), Name = "John Doe", Age = 20, StudentId = "s1" },
            //    new Student { Id = new Guid("54f2f515-54a1-454a-9585-54a1454a9588"), Name = "Jane Smith", Age = 22, StudentId = "s2" },
            //    new Student { Id = new Guid("54f2f515-54a1-454a-9585-54a1454a9589"), Name = "Sam Brown", Age = 19, StudentId = "s3" },
            //    new Student { Id = new Guid("54f2f515-54a1-454a-9585-54a1454a9590"), Name = "Lisa White", Age = 21, StudentId = "s4" },
            //    new Student { Id = new Guid("54f2f515-54a1-454a-9585-54a1454a9591"), Name = "Tom Black", Age = 23, StudentId = "s5" }
            //};
            var studentClasses = new List<StudentClass>()
            {
                new StudentClass
                {
                    Id = new Guid("54f2f515-54a1-454a-9585-54a1454a9585"),
                    Name = "A",
                    },
                new StudentClass
                {
                    Id =  new Guid("54f2f515-54a1-454a-9585-54a1454a9586"),
                    Name = "B",
                    }
            };
            modelBuilder.Entity<StudentClass>().HasData(studentClasses);
        }
    }
}
