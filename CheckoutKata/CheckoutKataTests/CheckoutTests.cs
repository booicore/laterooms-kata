using System;
using System.Collections.Generic;
using CheckoutKata;
using CheckoutKata.Interfaces.Helpers;
using Moq;
using NUnit.Framework;

namespace CheckoutKataTests
{
    [TestFixture]
    public class CheckoutTests
    {
        private Mock<IAddToScannedItems> _mockAddToScannedItems;
        private Mock<IGrandTotal> _mockGrandTotal;

        [SetUp]
        public void SetUp()
        {
            _mockAddToScannedItems = new Mock<IAddToScannedItems>();
            _mockGrandTotal = new Mock<IGrandTotal>();
        }

        private Checkout CreateSUT()
        {
            return new Checkout(_mockAddToScannedItems.Object, _mockGrandTotal.Object);
        }

        [Test]
        public void Checkout_Scan_should_return_a_runningtotal_price()
        {
            var sut = CreateSUT();

            var scanned = new Dictionary<string, int>();

            _mockGrandTotal.Setup(x => x.GetGrandTotal(scanned)).Returns(10m);

            var response = sut.GetTotalPrice();

            Assert.IsTrue(response >= 10.0m);
        }

        [Test]
        public void Checkout_Scan_should_add_a_product_and_return_total_price()
        {
            var sku = "A";

            var scanned = new Dictionary<string, int>();

            scanned.Add(sku, 4);

            _mockAddToScannedItems.Setup(x => x.AddToScanned(It.IsAny<Dictionary<string, int>>(), sku)).Returns(scanned);
            _mockGrandTotal.Setup(x => x.GetGrandTotal(scanned)).Returns(50.0m);

            var sut = CreateSUT();

            var response = sut.Scan(sku);

            Assert.AreEqual(response, 50m);
        }
    }
}
