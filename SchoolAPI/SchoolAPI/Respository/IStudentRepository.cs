using SchoolAPI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SchoolAPI.Respository
{
    public interface IStudentRepository
    {
        Task<string> AddStudent(Student student);
        Task<int> DeleteStudent(int studentid);
        Task<Student> GetStudentByID(int studentid);
        Task<List<Student>> GetStudent();
        Task UpdateStudent(Student student);
    }
}