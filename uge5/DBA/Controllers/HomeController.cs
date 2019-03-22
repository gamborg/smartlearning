using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using DBA.Models;

namespace DBA.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Products()
        {
            var list = new List<CarViewModel>();
            list.Add(new CarViewModel {
                Image = "/images/2002_volvo_s60_t5.jpeg",
                Caption = "Volvo S60, 2,4 Business, Benzin",
                Description = "Volvo S60, 2,4 Business, Benzin, 2002, km 450, sølvmetal, klimaanlæg, ABS, airbag, alarm, 4-dørs, centrallås, startspærre, service ok, 380 servostyring<br /><br />Lige fået Stort service med tandrem skift nye tændspoler ,for+baghjulsbremser samt motorophæng m.m.Fuld læderkabine, org.volvo navigation ,fartpilot, sommer + vinterhjul nye. 3 ejer fra ny. Ny forrude lige monteret.",
                Brand = "Volvo",
                Model = "S60 2,4 Business",
                Price = 21000,
                Added = DateTime.Parse("25/02/2019"),
                Year = DateTime.Parse("01/01/2002"),
                Mileage = 450000
            });
            return View(list);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
