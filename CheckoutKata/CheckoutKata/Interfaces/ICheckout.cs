using System.Collections.Generic;

namespace CheckoutKata.Interfaces
{
    public interface ICheckout
    {
        Dictionary<string, int> Scanned { get; set; }
        decimal Scan(string sku);
        decimal GetTotalPrice();
       
    }
}