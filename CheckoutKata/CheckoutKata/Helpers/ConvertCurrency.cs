using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CheckoutKata.Interfaces.Helpers;

namespace CheckoutKata.Helpers
{
    public class ConvertCurrency : IConvertCurrency
    {
        
        public decimal Convert(decimal baseCurrencyValue, string local, string destination)
        {
            var CurrencyTable = new Dictionary<Tuple<string, string>, decimal>();
            CurrencyTable.Add(new Tuple<string, string>("gbp", "eur"), 1.17m);
            CurrencyTable.Add(new Tuple<string, string>("eur", "gbp"), 0.85m);

            var ItemOfCurrency = CurrencyTable.First(x => x.Key.Item1 == local && x.Key.Item2 == destination).Value;
            
            var response = ItemOfCurrency * baseCurrencyValue;

            return response;
        }


    }
}
