using Microsoft.AspNetCore.SignalR;
using my_pizza.Infrastructure.Factories;
using my_pizza.Models;
using System.Threading.Tasks;
using System.Linq;

namespace my_pizza.Infrastructure.Hubs
{
    public class OrderHub : Hub
    {
        private readonly IBasketFactory _basketFactory;
        private readonly CatalogContext _context;
        public BasketHub(IBasketFactory basketFactory, CatalogContext context) 
        {
            _basketFactory = basketFactory;
            _context = context;
        }

        public async Task AddToBasket(int productId, int qty)
        {
            var basket = await _basketFactory.GetBasket(Context.ConnectionId);
            var product = _context.Products.FirstOrDefault(p => p.Id == productId);
            
            await Clients.Caller.SendAsync("RecievedAddToBasket", basket.Add(new BasketItem { Product = product, Qty = qty }));
        }
    }
}