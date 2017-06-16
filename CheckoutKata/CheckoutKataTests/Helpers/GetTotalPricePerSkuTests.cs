using System;
using System.Text;
using System.Collections.Generic;
using CheckoutKata.Helpers;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace CheckoutKataTests.Helpers
{

    [TestFixture()]
    public class GetTotalPricePerSkuTests
    {
        [SetUp]
        public void SetUp()
        {
            
        }

        private GetTotalPricePerSku CreateSUT()
        {
            return new GetTotalPricePerSku();
        }

        [Test]
        public void GetPrice_should_return_a_total_price_per_product_type()
        {
            var expected = 230m;

            var sku = "A";

            var sut = CreateSUT();

            var response = sut.GetPrice(sku, 5);

            Assert.AreEqual(expected, response);
        }
    }
}
