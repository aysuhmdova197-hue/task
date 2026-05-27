using MVC_Fiorella.Models;

namespace MVC_Fiorella.Services.Interfaces
{
    public interface ISliderInfoService
    {
        Task<SliderInfo> GetAllAsync();
    }
}
