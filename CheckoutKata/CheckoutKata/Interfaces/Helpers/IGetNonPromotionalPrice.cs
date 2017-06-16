namespace CheckoutKata.Interfaces.Helpers
{
    public interface IGetNonPromotionalPrice
    {
        decimal Get(string sku, int quantity);
    }
}