using Microsoft.AspNetCore.Mvc;
using MVC_Fiorella.Models;
using MVC_Fiorella.Services.Interfaces;

namespace MVC_Fiorella.ViewComponents
{
    public class SliderViewComponent : ViewComponent
    {
        private readonly ISliderService _sliderService;
        private readonly ISliderInfoService _sliderInfoService;

        public SliderViewComponent(ISliderInfoService sliderInfoService, ISliderService sliderService)
        {
            _sliderInfoService = sliderInfoService;
            _sliderService = sliderService;
        }

        // Yenilənmiş və təhlükəsiz metod bura yazılır:
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var sliders = await _sliderService.GetAllAsync();
            var sliderInfo = await _sliderInfoService.GetAllAsync();

            SliderVMVC model = new()
            {
                // Əgər sliders null-dursa, xəta verməsin, boş siyahı təyin etsin
                Sliders = sliders ?? Enumerable.Empty<Slider>(),
                SliderInfo = sliderInfo
            };

            return View(model);
        }
    }

    public class SliderVMVC
    {
        public IEnumerable<Slider> Sliders { get; set; }
        public SliderInfo SliderInfo { get; set; }
    }
}