using MVC_Fiorella.Models;

namespace MVC_Fiorella.Services.Interfaces
{
    public interface ISliderService
    {
        Task<IEnumerable<Slider>> GetAllAsync();
    }
}
