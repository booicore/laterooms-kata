using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckoutKata.Interfaces.Helpers
{
    public interface IConvertCurrency
    {
        decimal Convert(decimal baseCurrencyValue, string local, string destination);
    }
}
