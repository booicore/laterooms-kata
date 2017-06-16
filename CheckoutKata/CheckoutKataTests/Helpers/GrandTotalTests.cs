using System;
using System.Text;
using System.Collections.Generic;
using CheckoutKata.Helpers;
using NUnit.Framework;

namespace CheckoutKataTests.Helpers
{
    
    [TestFixture]
    public class GrandTotalTests
    {
        
        [SetUp]
        public void SetUp()
        {
            
        }

        private GrandTotal CreateSUT()
        {
            return new GrandTotal();
        }

        [Test]
        public void Get_should_return_a_valid_total()
        {
            var scanned = new Dictionary<string, int>();

            var sut = CreateSUT();

            var response = sut.GetGrandTotal(scanned);

            Assert.IsTrue(response >= 0.0m);

        }
    }
}
