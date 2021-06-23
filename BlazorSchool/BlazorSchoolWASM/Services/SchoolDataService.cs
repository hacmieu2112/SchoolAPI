using BlazorSchoolWASM.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace BlazorSchoolWASM.Services
{ 
    public class SchoolDataService : ISchoolDataService
    {
        private readonly HttpClient _httpClient;
        public SchoolDataService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public async Task<IEnumerable<Student>> GetAllStudent()
        {
            var apiResponse = await _httpClient.GetStreamAsync($"api/Student/GetStudent");
            return await JsonSerializer.DeserializeAsync<IEnumerable<Student>>
                                (apiResponse, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });

        }
        //lấy dữ liệu của 1 học sinh
        public async Task<Student> GetStudentDetails(int id)
        {
            var apiResponse = await _httpClient.GetStreamAsync($"api/Student/GetStudentByID?studentid={id}");
            return await JsonSerializer.DeserializeAsync<Student>
                                (apiResponse, new JsonSerializerOptions() { PropertyNameCaseInsensitive = true });
        }

        public async Task<Student> AddStudent(Student student)
        {
            var itemJson = new StringContent(JsonSerializer.Serialize(student), Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync("api/Student/AddStudent", itemJson);

            if (response.IsSuccessStatusCode)
            {
                var responseBody = await response.Content.ReadAsStreamAsync();
                return null;
            }
            return null;
        }

        public async Task DeleteStudent(int id)
        {
            await _httpClient.DeleteAsync($"api/Student/DeleteStudent?studentId={id}");
        }

        public async Task UpdateStudentDetails(Student student)
        {
            try
            {
                var itemJson = new StringContent(JsonSerializer.Serialize(student), Encoding.UTF8, "application/json");
                var response = await _httpClient.PostAsync($"api/Student/UpdateStudent", itemJson);

                if (response.IsSuccessStatusCode)
                {
                    var responseBody = await response.Content.ReadAsStreamAsync();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
