using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentTaxes
{
    public class INSS : ITax
    {
        public decimal Discount(decimal value)
        {
            decimal taxValue;

            if (value <= 1045)
                taxValue = value / 100 * 7.5m;
            else if (value > 1045 && value <= 2089.60m)
                taxValue = value / 100 * 9;
            else if (value > 2089.60m && value <= 3134.40m)
                taxValue = value / 100 * 12;
            else if (value > 3134.40m && value <= 6101.06m)
                taxValue = value / 100 * 14;
            else
                taxValue = 642.34m;

            return taxValue;
        }
    }
}
