using Contributors.Entities;
using System;
using System.Collections.Generic;

namespace Contributors
{
    class Program
    {
        static void Main(string[] args)
        {
            List<People> list = new List<People>();

            Console.Write("Enter the number of tax payers: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine($"Tax payer #{i} data:");
                Console.Write("Individual or company (i/c)?");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Annual Income: ");
                double annualincome = double.Parse(Console.ReadLine());

                if (ch == 'i')
                {
                    Console.Write("Health expeditures: ");
                    double healtExp = double.Parse(Console.ReadLine());
                    list.Add(new Individual(name, annualincome, healtExp));
                }
                else
                {
                    Console.Write("Number of employees: ");
                    int emp = int.Parse(Console.ReadLine());
                    list.Add(new Legal(name, annualincome, emp));
                    
                }

            }

            Console.WriteLine();
            Console.WriteLine("TAXES PAID:");

            double sum = 0.0;

            foreach(People p in list)
            {
                Console.WriteLine(p.Name + ": $ " + p.Taxes().ToString("F2") );
                sum += p.Taxes();

            }

            Console.WriteLine();
            Console.Write("TOTAL TAXES: " + sum.ToString("F2"));
            Console.WriteLine();

        }
    }
}
