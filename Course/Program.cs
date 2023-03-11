using System;
using System.Globalization;
using System.Collections.Generic;
using Course.Entities;

namespace Course
{
    class Program
    {
        static void Main()
        {
            List<TaxPayer> list = new List<TaxPayer>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)? ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Anual income: ");
                double anualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                switch (ch)
                {
                    case 'i':
                        Console.Write("Health expenditures: ");
                        double healthExpenditure = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        list.Add(new Individual(name, anualIncome, healthExpenditure));
                        break;
                    case 'c':
                        Console.Write("Number of employees: ");
                        int numberOfEmployees = int.Parse(Console.ReadLine());
                        list.Add(new Company(name, anualIncome, numberOfEmployees));
                        break;
                    default:
                        Console.WriteLine("invalid char");
                        break;
                }
            }
            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");

            double sum = 0.0;
            foreach (TaxPayer taxPayer in list)
            {
                Console.WriteLine(taxPayer);
                sum += taxPayer.Taxes();
            }
            Console.WriteLine();
            Console.WriteLine("TOTAL TAXES: $ " + sum.ToString("F2", CultureInfo.InvariantCulture));
        }
    }
}