using System.Collections.Generic;
using CheckoutKata.DAL;
using CheckoutKata.Helpers;
using CheckoutKata.Interfaces.Helpers;
using Moq;
using NUnit.Framework;

namespace CheckoutKataTests.Helpers
{
    [TestFixture]
    public class ConvertCurrencyTests
    {
        [SetUp]
        public void SetUp()
        {
            
        }

        private ConvertCurrency CreateSUT()
        {
            return new ConvertCurrency();
        }

        [Test]
        public void Convert_should_change_local_currency_to_destination()
        {
            var expected = 117.0m;

            var baseCurrencyValue = 100.0m;

            var locale = "gbp";

            var destination = "eur";

            var sut = CreateSUT();

            var response = sut.Convert(baseCurrencyValue, locale, destination);

            Assert.AreEqual(expected, response);
        }
    }
}
