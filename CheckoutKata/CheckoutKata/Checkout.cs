using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CheckoutKata.Interfaces;

namespace CheckoutKata
{
    public class Checkout : ICheckout
    {
        public decimal Scan(string sku)
        {
            return 0.0m;
        }

        public decimal GetTotalPrice()
        {
            throw new NotImplementedException();
        }
    }
}
