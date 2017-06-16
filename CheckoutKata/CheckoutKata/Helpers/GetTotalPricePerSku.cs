using CheckoutKata.Interfaces.Helpers;

namespace CheckoutKata.Helpers
{
    public class GetTotalPricePerSku : IGetTotalPricePerSku
    {
        private IGetNonPromotionalPrice _getNonPromotionalPrice;
        private IGetPromotionalPrice _getPromotionalPrice;

        public GetTotalPricePerSku(IGetNonPromotionalPrice getNonPromotionalPrice, IGetPromotionalPrice getPromotionalPrice)
        {
            _getNonPromotionalPrice = getNonPromotionalPrice;
            _getPromotionalPrice = getPromotionalPrice;
        }

        public decimal GetPrice(string sku, int quantity)
        {
            var promoprice = _getPromotionalPrice.Get(sku, quantity);
            
            var nonpromoprice = _getNonPromotionalPrice.Get(sku, quantity);
            
            return promoprice + nonpromoprice; 
        }
    }
}