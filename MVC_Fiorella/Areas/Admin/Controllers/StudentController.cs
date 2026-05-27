using Microsoft.AspNetCore.Mvc;
using MVC_Fiorella.Services.Interfaces;
using MVC_Fiorella.ViewModels.Student;

namespace MVC_Fiorella.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class StudentController : Controller
    {

        private readonly IStudentService _studentService;
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var students = await _studentService.GetAllAdminAsync();
            return View(students);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(StudentCreateVM request)
        {
            if (!ModelState.IsValid)
            {
                return View(request);
            }
            await _studentService.CreateAsync(request);
            return RedirectToAction(nameof(Index));

        }
        [HttpGet]
        public async Task<IActionResult> Detail(int? id)
        {
            if (id is null) BadRequest();
            var student = await _studentService.GetById(id.Value);
            if (student is null) return NotFound();
            return View(student);
        }

    }
}
