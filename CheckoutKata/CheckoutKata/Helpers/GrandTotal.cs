using System.Collections.Generic;
using CheckoutKata.Interfaces.Helpers;

namespace CheckoutKata.Helpers
{
    public class GrandTotal : IGrandTotal
    {
        public decimal GetGrandTotal(Dictionary<string, int> scanned)
        {
            var grandTotal = 0.0m;

            // loop through scanned 

            // get a product price per product and calculate the promotion price total and any single price totals
                // add them together: promotionTotal + singlesTotal
                // predicting using Modulus here

            // get totals for each product type and add them to the grandTotal

            return grandTotal;
        }
    }
}