using CheckoutKata.Helpers;
using NUnit.Framework;

namespace CheckoutKataTests.Helpers
{
    [TestFixture]
    public class GetNonPromotionalPriceTests
    {
        [SetUp]
        public void SetUp()
        {

        }


        private GetNonPromotionalPrice CreateSUT()
        {
            return new GetNonPromotionalPrice();
        }

        [Test]
        public void get_should_return_the_sum_total_for_the_non_promotional_only()
        {
            var sku = "B";

            var quantity = 5;

            var expected = 30m;

            var sut = CreateSUT();

            var response = sut.Get(sku, quantity);

            Assert.AreEqual(response, expected);
        }

        [Test]
        public void get_should_return_the_sum_total_for_the_non_promotional_when_none()
        {
            var sku = "B";

            var quantity = 2;

            var expected = 0m;

            var sut = CreateSUT();

            var response = sut.Get(sku, quantity);

            Assert.AreEqual(response, expected);
        }

        [Test]
        public void get_should_return_the_sum_total_for_the_non_promotional_when_no_promo_present()
        {
            var sku = "C";

            var quantity = 3;

            var expected = 60m;

            var sut = CreateSUT();

            var response = sut.Get(sku, quantity);

            Assert.AreEqual(response, expected);
        }
    }
}