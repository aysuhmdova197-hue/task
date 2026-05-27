using Microsoft.EntityFrameworkCore;
using MVC_Fiorella.Data;
using MVC_Fiorella.Models;
using MVC_Fiorella.Services.Interfaces;

namespace MVC_Fiorella.Services
{
    public class BlogService : IBlogService
    {
        private readonly AppDbContext _context;
        public BlogService(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IEnumerable<Blog>> GetAllAsync()
        {
            return await _context.Blogs.Include(m => m.BlogImages).ToListAsync();
        }

        public async Task<Blog> GetById(int id)
        {
            return await _context.Blogs.Include(m => m.BlogImages).FirstOrDefaultAsync(m => m.Id == id);    
        }
    }
}
