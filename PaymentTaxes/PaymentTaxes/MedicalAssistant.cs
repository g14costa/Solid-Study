using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentTaxes
{
    public class MedicalAssistant : ITax
    {
        public decimal Discount(decimal value)
        {
            if (value < 1000)
                return 0;
            else if (value > 1000 && value < 5000)
                return 50;
            else
                return 100;
        }
    }
}
