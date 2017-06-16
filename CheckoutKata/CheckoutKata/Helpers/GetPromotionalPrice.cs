using CheckoutKata.Interfaces.DAL;
using CheckoutKata.Interfaces.Helpers;

namespace CheckoutKata.Helpers
{
    public class GetPromotionalPrice : IGetPromotionalPrice
    {
        private IGetProductsStubData _getProductsStubData;

        public GetPromotionalPrice(IGetProductsStubData getProductsStubData)
        {
            _getProductsStubData = getProductsStubData;
        }

        public decimal Get(string sku, int quantity)
        {
            var productsList = _getProductsStubData.GetProductsData();


            return 0.0m;
        }
    }
}