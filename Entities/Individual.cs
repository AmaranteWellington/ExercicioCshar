
namespace Exercicio.Entities
{
    internal class Individual:TaxPayer
    {
        public double HearthExpenditures { get; set; }

        public Individual() 
        {
        }

        public Individual(string name, double anualIncome , double hearthExpenditures):base(name,anualIncome)
        {
            HearthExpenditures = hearthExpenditures;
        }

        public override double Tax()
        {
            if (AnualIncome < 20000.0)
            {
                return AnualIncome * 0.15 - HearthExpenditures * 0.5;
            }
            else 
            {
               return AnualIncome * 0.25 - HearthExpenditures * 0.5;
            }

            
        }
    }
}
