using SchoolAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SchoolAPI.Respository
{
    public interface IStudentInClassRepository
    {
        Task<int> AddStudentToClass(StudentInClass studentinclass);
        Task<int> DeleteStudentInClass(string ClassName, string StudentName);
        Task<List<StudentInClass>> GetStudentInClass();
        Task<StudentInClass> GetStudentInClassByName(string ClassName, string StudentName);
        Task UpdateStudentInClass(StudentInClass studentinclass);
    }
}