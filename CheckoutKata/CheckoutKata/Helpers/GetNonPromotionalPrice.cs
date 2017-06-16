using System.Linq;
using CheckoutKata.Interfaces.DAL;
using CheckoutKata.Interfaces.Helpers;

namespace CheckoutKata.Helpers
{
    public class GetNonPromotionalPrice : IGetNonPromotionalPrice
    {
        private IGetProductsStubData _getProductsStubData;

        public GetNonPromotionalPrice(IGetProductsStubData getProductsStubData)
        {
            _getProductsStubData = getProductsStubData;
        }

        public decimal Get(string sku, int quantity)
        {
            decimal? price = 0.0m;

            var productsList = _getProductsStubData.GetProductsData();
            
            var product = productsList.Single(x => x.Sku == sku);

            var productOfferQuantity = product.OfferQuantity;

            if (quantity > productOfferQuantity && productOfferQuantity != 0)
            {
                var productQuantityOutsideOffer = quantity % productOfferQuantity;
                price = productQuantityOutsideOffer * product.Price;
            }
            
            if (quantity < productOfferQuantity && quantity >= 0 || productOfferQuantity == 0)
            {
                price = quantity * product.Price;
            }

            return price.Value;

        }
    }
}