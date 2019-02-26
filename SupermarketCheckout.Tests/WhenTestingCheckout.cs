using NUnit.Framework;

namespace SupermarketCheckout.Tests
{
    public class WhenTestingCheckout
    {
        private ICheckout Checkout { get; set; }
        private Item ItemA { get; set; }
        
        [SetUp]
        public void SetUp()
        {
            Checkout = new Checkout();

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
    }
}