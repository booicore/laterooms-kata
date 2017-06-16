using System.Linq;
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
            decimal? price = 0.0m;

            var productsList = _getProductsStubData.GetProductsData();
            
            var product = productsList.Single(x => x.Sku == sku);
            
            var productOfferQuantity = product.OfferQuantity;

            var productOfferPrice = product.OfferQuantityPrice;

            int? productQuantityOutsideOffer;

            if (productOfferQuantity != 0 && productOfferPrice != 0m)
            {
                productQuantityOutsideOffer = quantity % productOfferQuantity;
                price = ((quantity - productQuantityOutsideOffer) / product.OfferQuantity) * productOfferPrice;
            }
            
            return price.Value;
        }
    }
}