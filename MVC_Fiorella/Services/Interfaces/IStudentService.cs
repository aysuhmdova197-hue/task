using MVC_Fiorella.ViewModels.Student;

namespace MVC_Fiorella.Services.Interfaces
{
    public interface IStudentService
    {
        Task<IEnumerable<StudentUIVM>> GetAllAsync();
        Task<IEnumerable<StudentVM>> GetAllAdminAsync();
        Task<StudentDetailVM> GetById(int id);
        Task CreateAsync(StudentCreateVM model);
        Task UpdateAsync(int id, StudentUpdateVM model);
        Task DeleteAsync(int id);
    }
}
