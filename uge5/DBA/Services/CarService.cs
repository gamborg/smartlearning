using System;
using System.Collections.Generic;
using System.Linq;
using DBA.Models;

namespace DBA.Services
{
    public class CarService : ICarService
    {
        public IEnumerable<CarViewModel> GetCarsForSale()
        {
            var list = new List<CarViewModel>();
            list.Add(new CarViewModel
            {
                Caption = "Volvo S60, 2,4 170 Business, Benzin",
                Description = "Volvo S60, 2,4 170 Business, Benzin, 2003, km 350253, blåmetal, træk, klimaanlæg, aircondition, ABS, airbag, alarm, 4-dørs, centrallås, startspærre, service ok, 17\" alufælge servostyring<br /><br />Pæn og Velkørende bil med læderkabine og en masse ekstra udstyr. 4 vinterdæk og fælge medfølger",
                Image = "/images/2002_volvo_s60_t5.jpeg",
                Price = 24900,
                Added = DateTime.Now,
                Brand = "Volvo",
                Model = "S60, 2,4 170 Business",
                Mileage = 350253,
                Year = DateTime.Parse("2003/01/01")

            });
            return list;
        }
    }
}