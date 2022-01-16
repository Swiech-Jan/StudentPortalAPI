using StudentPortalAPI.Models;
using System.Linq;

namespace StudentPortalAPI.Repositories
{
    public class SqlStudentRepository : IStudentRepository
    {
        private readonly StudentPortalContext context;

        public SqlStudentRepository(StudentPortalContext context)
        {
            this.context = context;
        }
        public List<Student> GetStudents()
        {
            return context.Student.ToList();
        }
    }
}
