using System;
using System.Text;
using System.Collections.Generic;
using CheckoutKata.Entities;
using NUnit.Framework;

namespace CheckoutKataTests
{

    [TestFixture]
    public class GetProductsStubDataTests
    {
        [SetUp]
        public void SetUp()
        {
            
        }

        private GetProductsStubData CreateSUT()
        {
            return new GetProductsStubData();
        }

        [Test]
        public void GetProductsData_should_return_our_Products_stub_data()
        {
            var sut = CreateSUT();

            var response = sut.GetProductsStubData();

            Assert.IsInstanceOf<List<Product>>(response);
        }
    }
}
