namespace Course.Entities
{
    class Company : TaxPayer
    {
        public int NumberOfEmployees { get; set; }

        public Company(string name, double anualIncome, int numberOfEmployees)
            : base(name, anualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }

        public override double Taxes()
        {
            double taxPercentage, tax;
            if (NumberOfEmployees > 10)
            {
                taxPercentage = 0.14;
            }
            else
            {
                taxPercentage = 0.16;
            }
            tax = AnualIncome * taxPercentage;
            return tax;
        }
    }
}
