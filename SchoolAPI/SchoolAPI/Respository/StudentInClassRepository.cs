
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SchoolAPI.Models;
using System.Data.Common;
using System;

namespace SchoolAPI.Respository
{
    public class StudentInClassRepository : IStudentInClassRepository
    {
        SchoolContext db;
        public StudentInClassRepository(SchoolContext _db)
        {
            db = _db;
            //db = _db ?? throw new ArgumentNullException(nameof(_db));
        }
        public async Task<List<StudentInClass>> GetStudentInClass()
        {
            if (db != null)
            {
                return await db.StudentInClasses.ToListAsync();
            }

            return null;
        }
        public async Task<int> AddStudentToClass(StudentInClass studentinclass)
        {
            if (db != null)
            {
                await db.StudentInClasses.AddAsync(studentinclass);
                await db.SaveChangesAsync();

                return studentinclass.ClassID;
            }

            return 0;
        }
        public async Task<int> DeleteStudentInClass(string ClassName, string StudentName)
        {
            int result = 0;

            if (db != null)
            {
                var studentinclass = await (from sc in db.StudentInClasses
                                            join c in db.Classes on sc.ClassID equals c.ClassID
                                            join s in db.Students on sc.StudentID equals s.StudentID
                                            where c.ClassName == ClassName
                                            where s.StudentName == StudentName
                                            select new StudentInClass
                                            {
                                                SCID = sc.SCID,
                                                ClassID = c.ClassID,
                                                StudentID = s.StudentID
                                            }).FirstOrDefaultAsync();
                if (studentinclass != null)
                {
                    db.StudentInClasses.Remove(studentinclass);
                    result = await db.SaveChangesAsync();
                }
                return result;
            }

            return result;
        }
        public async Task UpdateStudentInClass(StudentInClass studentinclass)
        {
            if (db != null)
            {
                db.StudentInClasses.Update(studentinclass);

                await db.SaveChangesAsync();
            }
        }

        public async Task<StudentInClass> GetStudentInClassByName(string ClassName, string StudentName)
        {
            if (db != null)
            {
                return await (from sc in db.StudentInClasses
                              join c in db.Classes on sc.ClassID equals c.ClassID
                              join s in db.Students on sc.StudentID equals s.StudentID
                              where c.ClassName==ClassName
                              where s.StudentName == StudentName
                              select new StudentInClass
                              {
                                  SCID = sc.SCID,
                                  ClassID = c.ClassID,
                                  StudentID = s.StudentID
                              }).FirstOrDefaultAsync();
            }

            return null;
        }
    }
}
