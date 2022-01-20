using StudentPortalAPI.Models;

namespace StudentPortalAPI.Repositories
{
    public interface IStudentRepository
    {
       Task <List<Student>> GetStudentsAsync();
       Task<Student> GetStudentAsync(Guid studentId);
       Task<List<Gender>>GetGendersAsync();

        Task<bool> Exists(Guid studentId);

        Task<Student> UpdateStudent(Guid studentId, Student request);
    }
}
