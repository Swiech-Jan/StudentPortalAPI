using StudentPortalAPI.Models;

namespace StudentPortalAPI.Repositories
{
    public interface IStudentRepository
    {
        List<Student> GetStudents();
    }
}
