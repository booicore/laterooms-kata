using System.Collections.Generic;
using CheckoutKata.Interfaces.Helpers;

namespace CheckoutKata.Helpers
{
    public class AddToScannedItems : IAddToScannedItems
    {
        public Dictionary<string, int> AddToScanned(Dictionary<string, int> scanned, string sku)
        {
            //TODO: add sku to scannned here

            return scanned;
        }
    }
}