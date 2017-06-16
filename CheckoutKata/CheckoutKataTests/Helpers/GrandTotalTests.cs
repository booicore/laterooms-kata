using System;
using System.Text;
using System.Collections.Generic;
using CheckoutKata.DAL;
using CheckoutKata.Helpers;
using CheckoutKata.Interfaces.Helpers;
using Moq;
using NUnit.Framework;

namespace CheckoutKataTests.Helpers
{
    
    [TestFixture]
    public class GrandTotalTests
    {
        private Mock<IGetTotalPricePerSku> _mockGetTotalPricePerSku;

        [SetUp]
        public void SetUp()
        {
            _mockGetTotalPricePerSku = new Mock<IGetTotalPricePerSku>();
        }

        private GrandTotal CreateSUT()
        {
            return new GrandTotal(_mockGetTotalPricePerSku.Object);
        }

        [Test]
        public void Get_should_return_a_valid_total()
        {
            var scanned = new Dictionary<string, int>();

            var sut = CreateSUT();

            var response = sut.GetGrandTotal(scanned);

            Assert.IsTrue(response >= 0.0m);

        }

        [Test]
        public void Get_should_add_up_the_products_cost_using_the_prices_set_in_Products_stub_data()
        {
            var getProductsStubData = new GetProductsStubData();

            var stubData = getProductsStubData.GetProductsData();

            var scanned = new Dictionary<string, int>();

            scanned.Add("A", 4); // 180m
            scanned.Add("B", 2); // 45m
            scanned.Add("D", 4); // 60m

            _mockGetTotalPricePerSku.Setup(x => x.GetPrice("A", 4)).Returns(180m);
            _mockGetTotalPricePerSku.Setup(x => x.GetPrice("B", 2)).Returns(45m);
            _mockGetTotalPricePerSku.Setup(x => x.GetPrice("D", 4)).Returns(60m);

            var expected = 285.0m;

            var sut = CreateSUT();

            var response = sut.GetGrandTotal(scanned);

            Assert.AreEqual(expected, response);
        }
    }
}
