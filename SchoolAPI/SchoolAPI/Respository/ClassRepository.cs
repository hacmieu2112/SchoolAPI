
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SchoolAPI.Models;
using System.Data.Common;
using System;

namespace SchoolAPI.Respository
{
    public class ClassRepository : IClassRepository
    {
        SchoolContext db;
        public ClassRepository(SchoolContext _db)
        {
            db = _db;
            //db = _db ?? throw new ArgumentNullException(nameof(_db));
        }
        public async Task<List<Class>> GetClass()
        {
            if (db != null)
            {
                return await db.Classes.ToListAsync();
            }

            return null;
        }
        public async Task<string> AddClass(Class class1)
        {
            if (db != null)
            {
                await db.Classes.AddAsync(class1);
                await db.SaveChangesAsync();

                return class1.ClassName;
            }

            return "null";
        }
        public async Task<int> DeleteClass(int classId)
        {
            int result = 0;

            if (db != null)
            {
                var class1 = await db.Classes.FirstOrDefaultAsync(x => x.ClassID == classId);

                if (class1 != null)
                {
                    db.Classes.Remove(class1);
                    result = await db.SaveChangesAsync();
                }
                return result;
            }

            return result;
        }
        public async Task UpdateClass(Class class1)
        {
            if (db != null)
            {
                db.Classes.Update(class1);

                await db.SaveChangesAsync();
            }
        }

        public async Task<Class> GetClassByID(int classId)
        {
            if (db != null)
            {
                return await (from c in db.Classes
                              where c.ClassID == classId
                              select new Class
                              {
                                  ClassID = c.ClassID,
                                  ClassName = c.ClassName
                              }).FirstOrDefaultAsync();
            }

            return null;
        }
    }
}