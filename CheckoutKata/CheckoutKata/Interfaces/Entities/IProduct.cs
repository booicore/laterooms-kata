namespace CheckoutKata.Interfaces.Entities
{
    public interface IProduct
    {
        string Sku { get; set; }
        decimal Price { get; set; }
        int? OfferQuantity { get; set; }
        decimal? OfferQuantityPrice { get; set; }
    }
}