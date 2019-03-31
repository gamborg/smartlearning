using DBA.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace DBA.ViewComponents.CarListComponent
{
    [ViewComponent(Name = "CarList")]
    public class CarListViewComponent : ViewComponent
    {
        private readonly ICarService _carService;
        public CarListViewComponent(ICarService carService) 
        {
            _carService = carService;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            return await Task.FromResult(View(_carService.GetCarsForSale()));
        }
    }
}