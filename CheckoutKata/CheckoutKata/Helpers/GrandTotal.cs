using System.Collections.Generic;
using CheckoutKata.Interfaces.DAL;
using CheckoutKata.Interfaces.Helpers;

namespace CheckoutKata.Helpers
{
    public class GrandTotal : IGrandTotal
    {
        private IGetTotalPricePerSku _getTotalPricePerSku;

        public GrandTotal(IGetTotalPricePerSku getTotalPricePerSku)
        {
            _getTotalPricePerSku = getTotalPricePerSku;
        }
        
        public decimal GetGrandTotal(Dictionary<string, int> scanned)
        {
            var grandTotal = 0.0m;
            
            foreach (var skuAndTotalPerSku in scanned)
            {
                grandTotal += _getTotalPricePerSku.GetPrice(skuAndTotalPerSku.Key, skuAndTotalPerSku.Value);
            }
            
            return grandTotal;
        }
    }
}