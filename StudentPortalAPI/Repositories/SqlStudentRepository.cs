using StudentPortalAPI.Models;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace StudentPortalAPI.Repositories
{
    public class SqlStudentRepository : IStudentRepository
    {
        private readonly StudentPortalContext context;

        public SqlStudentRepository(StudentPortalContext context)
        {
            this.context = context;
        }
        public async Task<List<Student>> GetStudentsAsync()
        {
            return await context.Student.Include(nameof(Gender)).Include(nameof(Address)).ToListAsync();
        }
    }
}
