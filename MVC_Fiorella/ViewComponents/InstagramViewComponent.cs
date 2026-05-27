using Microsoft.AspNetCore.Mvc;

namespace MVC_Fiorella.ViewComponents
{
    public class InstagramViewComponent: ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
