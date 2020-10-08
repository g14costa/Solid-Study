using System;
using System.Collections.Generic;
using System.Text;

namespace PaymentTaxes
{
    public class Salary
    {
        public decimal BaseSalary { get; set; }
        public decimal SalaryValue { get; set; }

        public Salary(decimal value)
        {
            BaseSalary = value;
            SalaryValue = value;
        }

        public Salary Discount(List<ITax> tax)
        {
            tax.ForEach(i => SalaryValue -= i.Discount(BaseSalary));

            return this;
        }
    }
}
