using System;
using System.Collections.Generic;
using System.Linq;

namespace SupermarketCheckout
{
    public class Checkout : ICheckout
    {
        private List<Item> basket = new List<Item>();
        
        public int GetTotalPrice()
        {
            return basket.Sum(item => item.Price);
        }

        public void Scan(Item item)
        {
            basket.Add(item);
        }
    }
}