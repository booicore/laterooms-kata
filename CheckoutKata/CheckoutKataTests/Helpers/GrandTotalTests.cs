using System;
using System.Text;
using System.Collections.Generic;
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
            var sut = CreateSUT();

            var response = sut.GetGrandTotal();

            Assert.IsTrue(response >= 0.0m);

        }
    }
}
