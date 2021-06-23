
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SchoolAPI.Models;
using System.Data.Common;
using System;

namespace SchoolAPI.Respository
{
    public class StudentRepository : IStudentRepository
    {
        SchoolContext db;
        public StudentRepository(SchoolContext _db)
        {
            db = _db;
            //db = _db ?? throw new ArgumentNullException(nameof(_db));
        }
        public async Task<List<Student>> GetStudent()
        {
            if (db != null)
            {
                return await db.Students.ToListAsync();
            }

            return null;
        }
        public async Task<string> AddStudent(Student student)
        {
            if (db != null)
            {
                await db.Students.AddAsync(student);
                await db.SaveChangesAsync();

                return student.StudentName;
            }

            return "null";
        }
        public async Task<int> DeleteStudent(int studentid)
        {
            int result = 0;

            if (db != null)
            {
                var student = await db.Students.FirstOrDefaultAsync(x => x.StudentID == studentid);

                if (student != null)
                {
                    db.Students.Remove(student);
                    result = await db.SaveChangesAsync();
                }
                return result;
            }

            return result;
        }
        public async Task UpdateStudent(Student student)
        {
            if (db != null)
            {
                db.Students.Update(student);

                await db.SaveChangesAsync();
            }
        }

        public async Task<Student> GetStudentByID(int studentid)
        {
            if (db != null)
            {
                return await (from s in db.Students
                              where s.StudentID == studentid
                              select new Student
                              {
                                  StudentID = s.StudentID,
                                  StudentName = s.StudentName
                              }).FirstOrDefaultAsync();
            }

            return null;
        }
    }
}
