using NUnit.Framework;

namespace SupermarketCheckout.Tests
{
    public class WhenTestingCheckout
    {
        private ICheckout Checkout { get; set; }
        
        [SetUp]
        public void SetUp()
        {
            Checkout = new Checkout();
        }

        [Test]
        public void WhenNoItemsAreScannedTotalPriceIsZero()
        {
            int total = Checkout.GetTotalPrice();
            
            Assert.That(total, Is.EqualTo(0));
        }
    }
}