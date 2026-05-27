using Microsoft.AspNetCore.Mvc;
using MVC_Fiorella.Services.Interfaces;

namespace MVC_Fiorella.Controllers
{
    public class BlogController : Controller
    {
        private readonly IBlogService _blogService;
        public BlogController(IBlogService blogService)
        {
            _blogService = blogService;
        }
        public async Task<IActionResult> Index()
        {
            
            return View();
        }
        public async Task<IActionResult> Detail(int id)
        {
            var blog = await _blogService.GetById(id);
            return View(blog);
        }
    }
}
