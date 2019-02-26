using NUnit.Framework;

namespace SupermarketCheckout.Tests
{
    public class WhenTestingCheckout
    {
        private ICheckout CheckOut { get; set; }
        
        [SetUp]
        public void SetUp()
        {
            CheckOut = new Checkout();
        }
    }
}