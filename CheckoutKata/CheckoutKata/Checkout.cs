using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CheckoutKata.Interfaces;
using CheckoutKata.Interfaces.Helpers;

namespace CheckoutKata
{
    public class Checkout : ICheckout
    {
        private IAddToScannedItems _addToScannedItems;

        public Dictionary<string, int> Scanned { get; set; }

        public Checkout(IAddToScannedItems addToScannedItems)
        {
            _addToScannedItems = addToScannedItems;

            Scanned = new Dictionary<string, int>();
        }

        public decimal Scan(string sku)
        {
            var grandTotal = 0.0m;
            
            Scanned =_addToScannedItems.AddToScanned(Scanned, sku);

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
