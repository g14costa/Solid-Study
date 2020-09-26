using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentTaxes
{
    public class INSS
    {
        public double TaxValue { get; set; }

        public INSS(float salary)
        {
            if (salary <= 1045)
                TaxValue = salary / 100 * 7.5;
            else if (salary > 1045 && salary <= 2089.60)
                TaxValue = salary / 100 * 9;
            else if (salary > 2089.60 && salary <= 3134.40)
                TaxValue = salary / 100 * 12;
            else if (salary > 3134.40 && salary <= 6101.06)
                TaxValue = salary / 100 * 14;
            else
                TaxValue = 642.34;
        }
    }
}
