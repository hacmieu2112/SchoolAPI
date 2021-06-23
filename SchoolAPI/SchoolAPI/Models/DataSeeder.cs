using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SchoolAPI.Respository;

namespace SchoolAPI.Models
{
    public class DataSeeder
    {
        public static void Seed(SchoolContext schoolContext)
        {
                schoolContext.Database.EnsureDeleted();
                schoolContext.Database.EnsureCreated();
            if (!schoolContext.Classes.Any())
            {
                var classes = new List<Class>
                {
                    new Class
                {
                    ClassID = 1,
                    ClassName = "SE1419"
                },
                new Class
                {
                    ClassID = 2,
                    ClassName = "SE1420"
                },
                new Class
                {
                    ClassID = 3,
                    ClassName = "SE1422"
                }
                };
                schoolContext.AddRange(classes);
                schoolContext.SaveChanges();
            }
            if (!schoolContext.Students.Any())
            {
                var student = new List<Student>
                {
                    new Student
                {
                    StudentID = 1,
                    StudentName = "Hoa"
                },
                new Student
                {
                    StudentID = 2,
                    StudentName = "Duong"
                },
                new Student
                {
                    StudentID = 3,
                    StudentName = "Tuan"
                },
                new Student
                {
                    StudentID = 4,
                    StudentName = "Hoang"
                },
                new Student
                {
                    StudentID = 5,
                    StudentName = "Hanh"
                }
                };
                schoolContext.AddRange(student);
                schoolContext.SaveChanges();
            }
            if (!schoolContext.StudentInClasses.Any())
            {
                var studentinclass = new List<StudentInClass>{
                    new StudentInClass
                    {
                        SCID = 1,
                        ClassID = 1,
                        StudentID = 2
                    },
                    new StudentInClass
                    {
                        SCID = 2,
                        ClassID = 2,
                        StudentID = 3
                    },
                    new StudentInClass
                    {
                        SCID = 3,
                        ClassID = 1,
                        StudentID = 4
                    },
                    new StudentInClass
                    {
                        SCID = 4,
                        ClassID = 3,
                        StudentID = 1
                    },
                    new StudentInClass
                    {
                        SCID = 5,
                        ClassID = 3,
                        StudentID = 5
                    }
                    };
                schoolContext.AddRange(studentinclass);
                schoolContext.SaveChanges();
            }
        }
    }
}
