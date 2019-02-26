using System.Collections.Generic;
using NUnit.Framework;
using SupermarketCheckout.Models;

namespace SupermarketCheckout.Tests
{
    public class WhenTestingCheckout
    {
        private ICheckout Checkout { get; set; }
        private Item ItemA { get; set; }
        private List<SpecialPrice> SpecialPrices { get; set; }
        
        [SetUp]
        public void SetUp()
        {
            SpecialPrices = new List<SpecialPrice>
            {
                new SpecialPrice
                {
                    Name = "A",
                    Quantity = 3,
                    Price = 130
                },
                new SpecialPrice
                {
                    Name = "B",
                    Quantity = 2,
                    Price = 45
                }
            };
            
            Checkout = new Checkout(SpecialPrices);

            ItemA = new Item
            {
                Name = "A",
                Price = 50
            };
        }

        [Test]
        public void WhenNoItemsAreScannedTotalPriceIsZero()
        {
            int total = Checkout.GetTotalPrice();
            
            Assert.That(total, Is.EqualTo(0));
        }

        [Test]
        public void WhenOneItemIsScannedCheckTotalPriceIsCorrect()
        {
            Checkout.Scan(ItemA);

            int total = Checkout.GetTotalPrice();
            
            Assert.That(total, Is.EqualTo(ItemA.Price));
        }

        [Test]
        public void WhenSpecialPriceIsUsedTotalPriceIsCorrect()
        {
            Checkout.Scan(ItemA);
            Checkout.Scan(ItemA);
            Checkout.Scan(ItemA);

            int total = Checkout.GetTotalPrice();
            
            Assert.That(total, Is.EqualTo(130));
        }
    }
}