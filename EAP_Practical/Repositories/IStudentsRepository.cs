using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EAP_Practical.Repositories
{
    public interface IStudentsRepository
    {
        Task<IEnumerable<Student>> GetStudentsAsync();
        Task<Student> GetStudentByIdAsync(int id);
        Task AddStudentAsync(Student student);
        Task DeleteStudentAsync(int id);
        Task UpdateStudentAsync(Student student);
        Task SaveChangesAsync();

    }
}
