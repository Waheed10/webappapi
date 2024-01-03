namespace webappapi.Client.Services
{
    public class StudentService
    {
        // ... existing code ...

        public async Task<IEnumerable<Student>> GetStudentsAsync()
        {
            return await _httpClient.GetFromJsonAsync<IEnumerable<Student>>("api/students");
        }

        public async Task<Student> AddStudentAsync(Student student)
        {
            var response = await _httpClient.PostAsJsonAsync("api/students", student);
            return await response.Content.ReadFromJsonAsync<Student>();
        }
    }
}
