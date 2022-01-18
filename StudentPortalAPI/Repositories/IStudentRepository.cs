using StudentPortalAPI.Models;

namespace StudentPortalAPI.Repositories
{
    public interface IStudentRepository
    {
       Task <List<Student>> GetStudentsAsync();
       Task<Student> GetStudentAsync(Guid studentId);
       Task<List<Gender>>GetGendersAsync();
    }
}
