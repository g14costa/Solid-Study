using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentTaxes
{
    public class IncomeTax
    {
        public double TaxValue { get; set; }

        public IncomeTax(float salary)
        {
            if (salary <= 1903.98)
                TaxValue = 0;
            else if (salary > 1903.98 && salary <= 2826.65)
                TaxValue = salary / 100 * 7.5;
            else if (salary > 2826.65 && salary <= 3751.05)
                TaxValue = salary / 100 * 15;
            else if (salary > 3751.05 && salary <= 4664.68)
                TaxValue = salary / 100 * 22.5;
            else
                TaxValue = salary / 100 * 27.5;
        }
    }
}
