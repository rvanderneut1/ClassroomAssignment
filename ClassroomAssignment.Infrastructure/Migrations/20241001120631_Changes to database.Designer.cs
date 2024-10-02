﻿// <auto-generated />
using System;
using ClassroomAssignment.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace ClassroomAssignment.Infrastructure.Migrations
{
    [DbContext(typeof(ClassroomAssignmentDBContext))]
    [Migration("20241001120631_Changes to database")]
    partial class Changestodatabase
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("ClassroomAssignment.Domain.Adress", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Adress");
                });

            modelBuilder.Entity("ClassroomAssignment.Domain.Models.Course", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<bool>("HasExam")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NumberOfLessons")
                        .HasColumnType("int");

                    b.Property<Guid>("StudentClassId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("StudentClassId");

                    b.ToTable("Course");
                });

            modelBuilder.Entity("ClassroomAssignment.Domain.Models.Student", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("AdressId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Age")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid?>("StudentClassId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("StudentId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("AdressId");

                    b.HasIndex("StudentClassId");

                    b.HasIndex("StudentId")
                        .IsUnique();

                    b.ToTable("Student", (string)null);
                });

            modelBuilder.Entity("ClassroomAssignment.Domain.Models.StudentClass", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("StudentClass", (string)null);

                    b.HasData(
                        new
                        {
                            Id = new Guid("54f2f515-54a1-454a-9585-54a1454a9585"),
                            Name = "A"
                        },
                        new
                        {
                            Id = new Guid("54f2f515-54a1-454a-9585-54a1454a9586"),
                            Name = "B"
                        });
                });

            modelBuilder.Entity("ClassroomAssignment.Domain.Models.Course", b =>
                {
                    b.HasOne("ClassroomAssignment.Domain.Models.StudentClass", "StudentClass")
                        .WithMany("Courses")
                        .HasForeignKey("StudentClassId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("StudentClass");
                });

            modelBuilder.Entity("ClassroomAssignment.Domain.Models.Student", b =>
                {
                    b.HasOne("ClassroomAssignment.Domain.Adress", "Adress")
                        .WithMany()
                        .HasForeignKey("AdressId");

                    b.HasOne("ClassroomAssignment.Domain.Models.StudentClass", "StudentClass")
                        .WithMany("Students")
                        .HasForeignKey("StudentClassId");

                    b.Navigation("Adress");

                    b.Navigation("StudentClass");
                });

            modelBuilder.Entity("ClassroomAssignment.Domain.Models.StudentClass", b =>
                {
                    b.Navigation("Courses");

                    b.Navigation("Students");
                });
#pragma warning restore 612, 618
        }
    }
}
