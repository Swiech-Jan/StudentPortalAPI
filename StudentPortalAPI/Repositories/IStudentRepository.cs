using StudentPortalAPI.Models;

namespace StudentPortalAPI.Repositories
{
    public interface IStudentRepository
    {
       Task <List<Student>> GetStudentsAsync();
    }
}
