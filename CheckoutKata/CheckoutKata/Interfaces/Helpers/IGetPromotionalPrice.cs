namespace CheckoutKata.Interfaces.Helpers
{
    public interface IGetPromotionalPrice
    {
        decimal Get(string sku, int quantity);
    }
}