using System;
using System.Text;
using System.Collections.Generic;
using CheckoutKata.DAL;
using CheckoutKata.Entities;
using CheckoutKata.Helpers;
using CheckoutKata.Interfaces.DAL;
using Moq;
using NUnit.Framework;

namespace CheckoutKataTests.Helpers
{
    
    [TestFixture]
    public class GetPromotionalPriceTests
    {

        private Mock<IGetProductsStubData> _mockGetProductsStubData;

        [SetUp]
        public void SetUp()
        {
            _mockGetProductsStubData = new Mock<IGetProductsStubData>();
        }

        private GetPromotionalPrice CreateSUT()
        {
            return new GetPromotionalPrice(_mockGetProductsStubData.Object);
        }

        [Test]
        public void get_should_return_the_sum_total_for_the_promotional_only()
        {
            var productsStubData = new GetProductsStubData();

            var productsData = productsStubData.GetProductsData();

            var sku = "A";

            var quantity = 5;

            var expected = 130m;

            _mockGetProductsStubData.Setup(x => x.GetProductsData()).Returns(productsData);

            var sut = CreateSUT();

            var response = sut.Get(sku, quantity);

            Assert.AreEqual(response, expected);
        }

        [Test]
        public void get_should_return_the_sum_total_for_the_promotional_only_when_no_promotion()
        {
            var productsStubData = new GetProductsStubData();

            var productsData = productsStubData.GetProductsData();

            var sku = "C";

            var quantity = 5;

            var expected = 100m;

            _mockGetProductsStubData.Setup(x => x.GetProductsData()).Returns(productsData);

            var sut = CreateSUT();

            var response = sut.Get(sku, quantity);

            Assert.AreEqual(response, expected);
        }

        [Test]
        public void get_should_return_the_sum_total_for_the_promotional_only_when_none()
        {
            var productsStubData = new GetProductsStubData();

            var productsData = productsStubData.GetProductsData();

            var sku = "B";

            var quantity = 1;

            var expected = 0m;

            _mockGetProductsStubData.Setup(x => x.GetProductsData()).Returns(productsData);

            var sut = CreateSUT();

            var response = sut.Get(sku, quantity);

            Assert.AreEqual(response, expected);
        }
    }
}
