namespace CheckoutKata.Interfaces
{
    public interface ICheckout
    {
        decimal Scan(string sku);
        decimal GetTotalPrice();

    }
}