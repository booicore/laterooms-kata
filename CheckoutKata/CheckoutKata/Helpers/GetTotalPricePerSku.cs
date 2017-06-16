using CheckoutKata.Interfaces.Helpers;

namespace CheckoutKata.Helpers
{
    public class GetTotalPricePerSku : IGetTotalPricePerSku
    {
        public decimal GetPrice(string sku, int quantity)
        {
            //TODO: Get the promotional cost 
            // get the non-promotional cost
            // add the two totals together

            throw new System.NotImplementedException();
        }
    }
}