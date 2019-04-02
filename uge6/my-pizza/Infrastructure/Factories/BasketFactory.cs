using System;
using System.Collections.Concurrent;
using System.Linq;
using System.Threading.Tasks;
using my_pizza.Infrastructure.Services;

namespace my_pizza.Infrastructure.Factories
{
    public interface IBasketFactory
    {
        Task<IBasketService> GetBasket(string connectionId);
    }

    public class BasketFactory : IBasketFactory
    {
        private static ConcurrentBag<BasketService> _baskets;
        static BasketFactory()
        {
            _baskets = new ConcurrentBag<BasketService>();
        }

        public async Task<IBasketService> GetBasket(string connectionId)
        {
            BasketService basket = await Task.FromResult(_baskets.FirstOrDefault(x => x.Id == connectionId));
            if (basket != null) return basket;

            basket = new BasketService(connectionId);
            _baskets.Add(basket);
            return basket;
        }
    }
}