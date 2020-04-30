namespace Contributors.Entities
{
    class Legal : People
    {
        public int EmployeeNumber { get; set; }

        public Legal()
        {
        }

        public Legal(string name, double annualIncome, int employeeNumber) 
            : base(name, annualIncome)
        {
            EmployeeNumber = employeeNumber;
        }

        public override double Taxes()
        {
            if (EmployeeNumber > 10)
            {
                return (AnnualIncome * 0.14);
            }

            else
            {
                return AnnualIncome;
            }

        }
    }
}
