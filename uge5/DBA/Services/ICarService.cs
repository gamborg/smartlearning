using System.Collections.Generic;
using DBA.Models;

namespace DBA.Services
{
    public interface ICarService
    {
         IEnumerable<CarViewModel> GetCarsForSale();
    }
}