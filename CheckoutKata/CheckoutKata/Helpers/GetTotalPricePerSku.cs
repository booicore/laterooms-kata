using CheckoutKata.Interfaces.Helpers;

namespace CheckoutKata.Helpers
{
    public class GetTotalPricePerSku : IGetTotalPricePerSku
    {
        public decimal GetPrice(string sku, int quantity)
        {
            //TODO: Get the promotional cost 

            //TODO:  get the non-promotional cost


            //TODO:  add the two totals together

            throw new System.NotImplementedException();
        }
    }
}