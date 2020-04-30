using System;
using System.Collections.Generic;
using System.Text;

namespace Contributors.Entities
{
    abstract class People
    {
        public string Name { get; set; }
        public double AnnualIncome { get; set; }

        public People()
        {
        }

        public People(string name, double annualIncome)
        {
            Name = name;
            AnnualIncome = annualIncome;
        }

        abstract public double Taxes();

    }
}
