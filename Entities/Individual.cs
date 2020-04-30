using System.Xml.Schema;

namespace Contributors.Entities
{
    class Individual : People
    {
        public double HealthExp { get; set; }

        public Individual()
        {
        }

        public Individual(string name, double annulaIncome, double healthExp)
            : base(name, annulaIncome)
        {
            HealthExp = healthExp;
        }

        public override double Taxes()
        {
            if (AnnualIncome < 20000.00)
            {
                return (AnnualIncome * 0.15) - (HealthExp * 0.50);
            }

            else
            {
                return (AnnualIncome * 0.25) - (HealthExp * 0.50);
            }

        }
    }
}
