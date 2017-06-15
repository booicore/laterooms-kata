using System;
using CheckoutKata;
using NUnit.Framework;

namespace CheckoutKataTests
{
    [TestFixture]
    public class CheckoutTests
    {
        [SetUp]
        public void SetUp()
        {
            
        }

        private Checkout CreateSUT()
        {
            return new Checkout();
        }

        [Test]
        public void Checkout_Scan_should_return_a_runningtotal_price()
        {
            var sut = CreateSUT();

            var response = sut.GetTotalPrice();

            Assert.IsTrue(response >= 0.0m);
        }
    }
}
