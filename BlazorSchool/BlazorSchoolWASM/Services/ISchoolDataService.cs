using BlazorSchoolWASM.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace BlazorSchoolWASM.Services
{
    public interface ISchoolDataService
    {
        Task<Student> AddStudent(Student student);
        Task DeleteStudent(int id);
        Task<IEnumerable<Student>> GetAllStudent();
        Task<Student> GetStudentDetails(int id);
        Task UpdateStudentDetails(Student student);
    }
}