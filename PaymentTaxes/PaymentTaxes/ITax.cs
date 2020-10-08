using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentTaxes
{
    public interface ITax
    {
        decimal Discount(decimal value);
    }
}
