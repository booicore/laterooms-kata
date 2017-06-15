using System.Collections.Generic;
using CheckoutKata.Entities;
using CheckoutKata.Interfaces.DAL;

namespace CheckoutKata.DAL
{
    public class GetProductsStubData : IGetProductsStubData
    {
        public List<Product> GetProductsData()
        {
            var products = new List<Product>()
            {
                new Product()
                {
                    Sku = "A",
                    Price = 50m,
                    OfferQuantity = 3,
                    OfferQuantityPrice = 130m
                },
                new Product()
                {
                    Sku = "B",
                    Price = 30m,
                    OfferQuantity = 2,
                    OfferQuantityPrice = 45m
                },
                new Product()
                {
                    Sku = "C",
                    Price = 20m,
                    OfferQuantity = 0,
                    OfferQuantityPrice = 0m
                },
                new Product()
                {
                    Sku = "D",
                    Price = 15m,
                    OfferQuantity = 0,
                    OfferQuantityPrice = 0m
                }
            };

            return products;
        }
    }
}