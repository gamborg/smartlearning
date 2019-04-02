using System;
using System.Collections.Generic;
using System.Linq;
using my_pizza.Models;

namespace my_pizza.Infrastructure.Services
{
    public interface IBasketService
    {
        string Id { get; }
        List<BasketItem> Add(BasketItem item);
        List<BasketItem> Remove(BasketItem item);
        List<BasketItem> GetBasket();
    }

    public class BasketService : IBasketService
    {
        public string Id { get; private set; }
        private List<BasketItem> _items;
        public BasketService() 
        {
            _items = new List<BasketItem>();
        }

        public BasketService(string id) 
        {
            _items = new List<BasketItem>();
            Id = id;
        }

        public List<BasketItem> Add(BasketItem item)
        {
            if (_items.FirstOrDefault(i => i.Product.Id == item.Product.Id) == null) {
                _items.Add(item);
            } else {
                _items.First(i => i.Product.Id == item.Product.Id).Qty += item.Qty;
            }

            return _items;
        }

        public List<BasketItem> Remove(BasketItem item) 
        {
            if (_items.Contains(item))
            {
                _items.Remove(item);
            }

            return _items;
        }

        public List<BasketItem> GetBasket() => _items;
    }
}