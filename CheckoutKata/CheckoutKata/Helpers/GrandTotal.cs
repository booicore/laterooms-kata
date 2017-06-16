using System.Collections.Generic;
using CheckoutKata.Interfaces.DAL;
using CheckoutKata.Interfaces.Helpers;

namespace CheckoutKata.Helpers
{
    public class GrandTotal : IGrandTotal
    {
        
        public decimal GetGrandTotal(Dictionary<string, int> scanned)
        {
            var grandTotal = 0.0m;

            // loop through scanned 
            foreach (var skuAndTotalPerSku in scanned)
            {
                // we need a GetTotalPricePerSku(skuAndTotalPerSku) class - 

                    // get a product price per product, plus calculate the promotion price total and any single price totals
                    // add them together: promotionTotal + singlesTotal
                    // predicting using Modulus here

                // get totals for each product type and add them to the grandTotal
            }
            
            return grandTotal;
        }
    }
}