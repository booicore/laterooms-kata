namespace CheckoutKata.Interfaces.Helpers
{
    public interface IGetTotalPricePerSku
    {
        decimal GetPrice(string sku, int quantity);
    }
}