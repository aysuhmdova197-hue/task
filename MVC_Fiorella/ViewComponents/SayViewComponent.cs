using Microsoft.AspNetCore.Mvc;

namespace MVC_Fiorella.ViewComponents
{
    public class SayViewComponent:ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }

}
