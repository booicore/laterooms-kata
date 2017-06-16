using System.Collections.Generic;

namespace CheckoutKata.Interfaces.Helpers
{
    public interface IAddToScannedItems
    {
        Dictionary<string, int> AddToScanned(Dictionary<string, int> scanned, string sku);
    }
}