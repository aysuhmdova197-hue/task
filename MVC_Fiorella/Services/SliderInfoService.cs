using Microsoft.EntityFrameworkCore;
using MVC_Fiorella.Data;
using MVC_Fiorella.Models;
using MVC_Fiorella.Services.Interfaces;

namespace MVC_Fiorella.Services
{
    public class SliderInfoService : ISliderInfoService
    {
        private readonly AppDbContext _context;
        public SliderInfoService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<SliderInfo> GetAllAsync()
        {
            return await _context.SliderInfos.FirstOrDefaultAsync();
        }
    }
}
