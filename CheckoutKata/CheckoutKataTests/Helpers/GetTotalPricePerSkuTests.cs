using System;
using System.Text;
using System.Collections.Generic;
using CheckoutKata.Helpers;
using CheckoutKata.Interfaces.Helpers;
using Moq;
using NUnit.Framework;
using NUnit.Framework.Internal;

namespace CheckoutKataTests.Helpers
{

    [TestFixture()]
    public class GetTotalPricePerSkuTests
    {
        private Mock<IGetPromotionalPrice> _mockGetPromotionalPrice;
        private Mock<IGetNonPromotionalPrice> _mockGetNonPromotionalPrice;

        [SetUp]
        public void SetUp()
        {
            _mockGetPromotionalPrice = new Mock<IGetPromotionalPrice>();
            _mockGetNonPromotionalPrice = new Mock<IGetNonPromotionalPrice>();
        }

        private GetTotalPricePerSku CreateSUT()
        {
            return new GetTotalPricePerSku(_mockGetNonPromotionalPrice.Object, _mockGetPromotionalPrice.Object);
        }

        [Test]
        public void GetPrice_should_return_a_total_price_per_product_type()
        {
            var expected = 230m;

            var quantity = 5;

            var sku = "A";

            _mockGetNonPromotionalPrice.Setup(x => x.Get(sku, quantity)).Returns(100m);
            _mockGetPromotionalPrice.Setup(x => x.Get(sku, quantity)).Returns(130m);

            var sut = CreateSUT();

            var response = sut.GetPrice(sku, quantity);

            Assert.AreEqual(expected, response);
        }

        [Test]
        public void GetPrice_should_return_a_total_price_per_product_type_when_nonpromo_is_zero()
        {
            var expected = 130m;

            var quantity = 3;

            var sku = "A";

            _mockGetNonPromotionalPrice.Setup(x => x.Get(sku, quantity)).Returns(0m);
            _mockGetPromotionalPrice.Setup(x => x.Get(sku, quantity)).Returns(130m);

            var sut = CreateSUT();

            var response = sut.GetPrice(sku, quantity);

            Assert.AreEqual(expected, response);
        }

        [Test]
        public void GetPrice_should_return_a_total_price_per_product_type_only_nonpromo()
        {
            var expected = 50m;

            var quantity = 1;

            var sku = "A";

            _mockGetNonPromotionalPrice.Setup(x => x.Get(sku, quantity)).Returns(50m);
            _mockGetPromotionalPrice.Setup(x => x.Get(sku, quantity)).Returns(0m);

            var sut = CreateSUT();

            var response = sut.GetPrice(sku, quantity);

            Assert.AreEqual(expected, response);
        }
    }
}
