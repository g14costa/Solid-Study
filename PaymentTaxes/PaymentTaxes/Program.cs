using System;
using System.Collections.Generic;

namespace PaymentTaxes
{
    class Program
    {
        static void Main(string[] args)
        {
            string userInput;
            Console.WriteLine("Consulta de impostos salariais");

            try
            {
                do
                {
                    Console.WriteLine("Digite o valor do salário ou S para sair: ");
                    userInput = Console.ReadLine();

                    if (userInput == "S")
                    {
                        break;
                    }

                    decimal salaryBaseValue;
                    decimal.TryParse(userInput, out salaryBaseValue);

                    if (salaryBaseValue == 0)
                    {
                        Console.WriteLine("Digite um valor válido");
                    }
                    else
                    {
                        Salary salary = new Salary(salaryBaseValue);
                        List<ITax> taxes = new List<ITax>();
                        taxes.Add(new INSS());
                        taxes.Add(new IncomeTax());
                        taxes.Add(new MedicalAssistant());

                        salary.Discount(taxes);

                        Console.WriteLine("O valor do salário com os descontos é: " + salary.SalaryValue);
                    }

                } while (true);
            }
            catch (Exception)
            {
                Console.WriteLine("Digite uma opção válida.");
            }
        }
    }
}
