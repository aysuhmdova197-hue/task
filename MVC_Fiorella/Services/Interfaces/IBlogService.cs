using MVC_Fiorella.Models;

namespace MVC_Fiorella.Services.Interfaces
{
    public interface IBlogService
    {
        Task<IEnumerable<Blog>> GetAllAsync();
        Task<Blog> GetById(int id);
    }
}
