using CheckoutKata.Interfaces.Entities;

namespace CheckoutKata.Entities
{
    public class Product : IProduct
    {
        public string Sku { get; set; }
        public decimal Price { get; set; }
        public int? OfferQuantity { get; set; }
        public decimal? OfferQuantityPrice { get; set; }
    }
}