using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CheckoutKata.Interfaces;

namespace CheckoutKata
{
    public class Checkout : ICheckout
    {
        public decimal Scan(string sku)
        {
            var grandTotal = 0.0m;

            //store the scanned product with the others...
            var scanned = new Dictionary<string, int>();
            
            // whip through the products and total them up
            
            // get price of product being scanned
            var priceOfProduct = 50m;

            return grandTotal += priceOfProduct;
            //return total

        }

        public decimal GetTotalPrice()
        {
            return 0.0m;
        }
    }
}
