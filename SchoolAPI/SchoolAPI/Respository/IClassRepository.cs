using SchoolAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SchoolAPI.Respository
{
    public interface IClassRepository
    {
        Task<string> AddClass(Class class1);
        Task<int> DeleteClass(int classId);
        Task<List<Class>> GetClass();
        Task<Class> GetClassByID(int classId);
        Task UpdateClass(Class class1);
    }
}