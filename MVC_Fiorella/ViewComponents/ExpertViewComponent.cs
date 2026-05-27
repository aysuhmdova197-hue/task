using Microsoft.AspNetCore.Mvc;

namespace MVC_Fiorella.ViewComponents
{
    public class ExpertViewComponent: ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
