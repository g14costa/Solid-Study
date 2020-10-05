using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentTaxes
{
    public class IncomeTax : ITax
    {
        public decimal Discount(decimal value)
        {
            decimal taxValue;

            if (value <= 1903.98m)
                taxValue = 0;
            else if (value > 1903.98m && value <= 2826.65m)
                taxValue = value / 100 * 7.5m;
            else if (value > 2826.65m && value <= 3751.05m)
                taxValue = value / 100 * 15;
            else if (value > 3751.05m && value <= 4664.68m)
                taxValue = value / 100 * 22.5m;
            else
                taxValue = value / 100 * 27.5m;

            return taxValue;
        }
    }
}
