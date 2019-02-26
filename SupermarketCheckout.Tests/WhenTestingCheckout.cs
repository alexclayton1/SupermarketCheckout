using NUnit.Framework;

namespace SupermarketCheckout.Tests
{
    public class WhenTestingCheckout
    {
        private ICheckOut CheckOut { get; set; }
        
        [SetUp]
        public void SetUp()
        {
            CheckOut = new CheckOut();
        }
    }
}