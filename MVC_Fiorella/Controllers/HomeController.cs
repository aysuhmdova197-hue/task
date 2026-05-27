using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_Fiorella.Data;
using MVC_Fiorella.Models;
using MVC_Fiorella.Services.Interfaces;

using System.Diagnostics;

namespace MVC_Fiorella.Controllers
{
    public class HomeController : Controller
    {
        public async Task <IActionResult> Index()
        {

            return View();
        }

   
    }
}
