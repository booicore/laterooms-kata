using System.Collections.Generic;
using CheckoutKata.Interfaces.Helpers;

namespace CheckoutKata.Helpers
{
    public class AddToScannedItems : IAddToScannedItems
    {
        public Dictionary<string, int> AddToScanned(Dictionary<string, int> scanned, string sku)
        {
            if (scanned.ContainsKey(sku))
            {
                scanned[sku] += 1;
            }
            if (!scanned.ContainsKey(sku))
            {
                scanned.Add(sku, 1);
            }

            return scanned;
        }
    }
}