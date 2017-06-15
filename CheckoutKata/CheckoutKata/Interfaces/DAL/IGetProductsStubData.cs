using System.Collections.Generic;
using CheckoutKata.Entities;

namespace CheckoutKata.Interfaces.DAL
{
    public interface IGetProductsStubData
    {
        List<Product> GetProductsData();
    }
}