using System;
using System.Collections.Generic;
using System.Linq;
using SupermarketCheckout.Models;

namespace SupermarketCheckout
{
    public class Checkout : ICheckout
    {
        private List<Item> basket;
        private List<SpecialPrice> SpecialPrices;

        public Checkout(List<SpecialPrice> specialPrices)
        {
            SpecialPrices = specialPrices;
            basket = new List<Item>();
        }
        
        public int GetTotalPrice()
        {
            var totalPrice = 0;
            
            var itemQuantities = basket.GroupBy(item => item.Name);

            foreach (var itemQuantity in itemQuantities)
            {
                var special = SpecialPrices.Find(price => price.Name == itemQuantity.Key);
                
                if (special != null)
                {
                    
                }
            }
            
            return basket.Sum(item => item.Price);
        }

        public void Scan(Item item)
        {
            basket.Add(item);
        }
    }
}