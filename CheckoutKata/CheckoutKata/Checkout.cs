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
        public Dictionary<string, int> Scanned { get; set; }

        public Checkout()
        {
            Scanned = new Dictionary<string, int>();
        }

        public decimal Scan(string sku)
        {
            var grandTotal = 0.0m;

            //add to scanned total
            if (Scanned.ContainsKey(sku)) {
                Scanned[sku] += 1;
            }
            if (!Scanned.ContainsKey(sku))
            {
                Scanned.Add(sku, 1);
            }

            // whip through the products and total them up

            // Get a list of the products/prices from somewhere - STUB DATA
            var priceOfProduct = 50m;

            return grandTotal += priceOfProduct;
            //return total

        }

        public decimal GetTotalPrice()
        {
            return 0.0m;
        }

        public int GetNumberOfScannedItems()
        {
            return Scanned.Sum(product => product.Value);
        }
    }
}
