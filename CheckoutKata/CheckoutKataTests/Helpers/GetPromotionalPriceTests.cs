using System;
using System.Text;
using System.Collections.Generic;
using CheckoutKata.Helpers;
using NUnit.Framework;

namespace CheckoutKataTests.Helpers
{
    
    [TestFixture]
    public class GetPromotionalPriceTests
    {

        [SetUp]
        public void SetUp()
        {
            
        }

        private GetPromotionalPrice CreateSUT()
        {
            return new GetPromotionalPrice();
        }

        [Test]
        public void get_should_return_the_sum_total_for_the_promotional_only()
        {
            var sku = "A";

            var quantity = 5;

            var expected = 130m;

            var sut = CreateSUT();

            var response = sut.Get(sku, quantity);

            Assert.AreEqual(response, expected);
        }

        [Test]
        public void get_should_return_the_sum_total_for_the_promotional_only_when_no_promotion()
        {
            var sku = "C";

            var quantity = 5;

            var expected = 100m;

            var sut = CreateSUT();

            var response = sut.Get(sku, quantity);

            Assert.AreEqual(response, expected);
        }

        [Test]
        public void get_should_return_the_sum_total_for_the_promotional_only_when_none()
        {
            var sku = "B";

            var quantity = 1;

            var expected = 0m;

            var sut = CreateSUT();

            var response = sut.Get(sku, quantity);

            Assert.AreEqual(response, expected);
        }
    }
}
