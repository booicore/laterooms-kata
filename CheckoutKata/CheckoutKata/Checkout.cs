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
        private IGrandTotal _grandTotal;

        public Dictionary<string, int> Scanned { get; set; }

        public Checkout(IAddToScannedItems addToScannedItems, IGrandTotal grandTotal)
        {
            _addToScannedItems = addToScannedItems;
            _grandTotal = grandTotal;

            Scanned = new Dictionary<string, int>();
        }

        public decimal Scan(string sku)
        {
            Scanned =_addToScannedItems.AddToScanned(Scanned, sku);

            return _grandTotal.GetGrandTotal(Scanned);
        }

        public decimal GetTotalPrice()
        {
            return _grandTotal.GetGrandTotal(Scanned);
        }

        public int GetNumberOfScannedItems()
        {
            return Scanned.Sum(product => product.Value);
        }
    }
}
