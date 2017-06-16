using CheckoutKata.DAL;
using CheckoutKata.Helpers;
using CheckoutKata.Interfaces.DAL;
using Moq;
using NUnit.Framework;

namespace CheckoutKataTests.Helpers
{
    [TestFixture]
    public class GetNonPromotionalPriceTests
    {
        private Mock<IGetProductsStubData> _mockGetProductsStubData;

        [SetUp]
        public void SetUp()
        {
            _mockGetProductsStubData = new Mock<IGetProductsStubData>();
        }


        private GetNonPromotionalPrice CreateSUT()
        {
            return new GetNonPromotionalPrice(_mockGetProductsStubData.Object);
        }

        [Test]
        public void get_should_return_the_sum_total_for_the_non_promotional_only()
        {
            var productsStubData = new GetProductsStubData();

            var productsData = productsStubData.GetProductsData();

            var sku = "B";

            var quantity = 5;

            var expected = 30m;

            _mockGetProductsStubData.Setup(x => x.GetProductsData()).Returns(productsData);

            var sut = CreateSUT();

            var response = sut.Get(sku, quantity);

            Assert.AreEqual(response, expected);
        }

        [Test]
        public void get_should_return_the_sum_total_for_the_non_promotional_when_none()
        {
            var productsStubData = new GetProductsStubData();

            var productsData = productsStubData.GetProductsData();

            var sku = "B";

            var quantity = 2;

            var expected = 0m;

            _mockGetProductsStubData.Setup(x => x.GetProductsData()).Returns(productsData);

            var sut = CreateSUT();

            var response = sut.Get(sku, quantity);

            Assert.AreEqual(response, expected);
        }

        [Test]
        public void get_should_return_the_sum_total_for_the_non_promotional_when_no_promo_present()
        {
            var productsStubData = new GetProductsStubData();

            var productsData = productsStubData.GetProductsData();

            var sku = "C";

            var quantity = 3;

            var expected = 60m;

            _mockGetProductsStubData.Setup(x => x.GetProductsData()).Returns(productsData);

            var sut = CreateSUT();

            var response = sut.Get(sku, quantity);

            Assert.AreEqual(expected, response);
        }
    }
}