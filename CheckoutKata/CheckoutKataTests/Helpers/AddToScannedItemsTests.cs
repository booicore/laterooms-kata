using System;
using System.Text;
using System.Collections.Generic;
using CheckoutKata.Helpers;
using NUnit.Framework;

namespace CheckoutKataTests.Helpers
{

    [TestFixture]
    public class AddToScannedItemsTests
    {
        [SetUp]
        public void SetUp()
        {
            
        }

        private AddToScannedItems CreateSUT()
        {
            return new AddToScannedItems();
        }

        [Test]
        public void SortScannedItems_should_return_item_totals_per_product()
        {
            var skuA = "A";
            var skuB = "B";

            var scanned = new Dictionary<string, int>();

            scanned.Add(skuA, 4);
            scanned.Add(skuB, 2);

            var sut = CreateSUT();

            var response = sut.AddToScanned(scanned, skuB);
            
            Assert.AreEqual(3, response["B"]);
        }
    }
}
