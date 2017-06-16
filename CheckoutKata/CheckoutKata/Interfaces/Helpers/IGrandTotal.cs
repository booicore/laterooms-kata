using System.Collections.Generic;

namespace CheckoutKata.Interfaces.Helpers
{
    public interface IGrandTotal
    {
        decimal GetGrandTotal(Dictionary<string, int> scanned);
    }
}