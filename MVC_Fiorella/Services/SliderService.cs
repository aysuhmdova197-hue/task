using Microsoft.EntityFrameworkCore;
using MVC_Fiorella.Data;
using MVC_Fiorella.Models;
using MVC_Fiorella.Services.Interfaces;

namespace MVC_Fiorella.Services
{
    public class SliderService : ISliderService
    {
        private readonly AppDbContext _context;
        public SliderService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Slider>> GetAllAsync()
        {
            return await _context.Sliders.ToListAsync();
        }
    }
}
