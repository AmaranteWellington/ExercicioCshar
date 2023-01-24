
using Exercicio.Entities;
using System.Globalization;

internal class Program
{
    private static void Main(string[] args)
    {
        List<TaxPayer> list = new List<TaxPayer>();

        Console.Write("Enter the number of tax payers: ");
        int n = int.Parse(Console.ReadLine());

        for ( int i =1; i <= n; i++)
        {
            Console.WriteLine($"Tax payer #{i} data:");
            Console.Write("Individual or company (i/c)? ");
            char ch = char.Parse(Console.ReadLine());
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Anual income: ");
            double anualIncome = double.Parse(Console.ReadLine(),CultureInfo.InvariantCulture);
            if(ch == 'i')
            {
                Console.Write("Health expenditures: ");
                double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                list.Add(new Individual(name, anualIncome, healthExpenditures));
            }
            else
            {
                Console.Write("Number of employees: ");
                int numberEmployees = int.Parse(Console.ReadLine());
                list.Add(new Company(name, anualIncome, numberEmployees));
            }
        }
        double sum = 0.0;
        Console.WriteLine();
        Console.WriteLine("TAXES PAID: ");
        foreach(TaxPayer taxPayer in list)
        {
            double tp = taxPayer.Tax();
            Console.WriteLine(taxPayer.Name
                + ": $"
                + tp.ToString("F2",CultureInfo.InvariantCulture));
            sum += tp;
        }

        Console.WriteLine();
        Console.WriteLine("TOTAL TAXES: $ " + sum.ToString("F2", CultureInfo.InvariantCulture));

    }
}