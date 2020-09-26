using System;

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

                    float salaryBaseValue;
                    float.TryParse(userInput, out salaryBaseValue);

                    if (salaryBaseValue == 0)
                    {
                        Console.WriteLine("Digite um valor válido");
                    }
                    else
                    {
                        Salary salary = new Salary();
                        INSS inss = new INSS(salaryBaseValue);
                        IncomeTax incomeTax = new IncomeTax(salaryBaseValue);

                        salary.TotalValue = salaryBaseValue - inss.TaxValue - incomeTax.TaxValue;

                        Console.WriteLine("O valor do salário com os descontos é: " + salary.TotalValue);
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
