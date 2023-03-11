namespace Course.Entities
{
    class Individual : TaxPayer
    {
        public double HealthExpenditures { get; set; }

        public Individual(string name, double anualIncome, double healthExpenditures)
            : base(name, anualIncome)
        {
            HealthExpenditures = healthExpenditures;
        }

        public override double Taxes()
        {
            double taxPercentage, tax;
            if (AnualIncome > 20000.00)
            {
                taxPercentage = 0.25;
            }
            else
            {
                taxPercentage = 0.15;
            }

            tax = AnualIncome * taxPercentage;

            if (HealthExpenditures > 0)
            {
                tax -= HealthExpenditures * 0.50;
            }
            return tax;
        }
    }
}
