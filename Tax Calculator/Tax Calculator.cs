using System;
namespace Tax
{
    class TaxCalc
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your gross income:");
            double grossIncome = double.Parse(Console.ReadLine()!);
            Calc(grossIncome);
        }
        static void Calc(double grossIncome)
        {
            double personalBasic = 12570; // The bound between the personal allowance and the basic rate.
            double basicHigher = 50270; // The bound between the basic rate and the higher rate.
            double higherAdditional = 125140; // The bound between the higher rate and the additional rate.
            double personalReduction = 100000; // The point a which the personal allowance is reduced from.
            double tax = 0;
            if (grossIncome > personalBasic && grossIncome <= basicHigher)
            {
                tax = (grossIncome - personalBasic) * 0.2;
            }
            else if (grossIncome > basicHigher && grossIncome <= personalReduction)
            {
                tax = ((basicHigher - personalBasic) * 0.2) + ((grossIncome - basicHigher) * 0.4);
            }
            else if (grossIncome > personalReduction && grossIncome <= higherAdditional)
            {
                tax = ((basicHigher - personalBasic) * 0.2) + ((grossIncome - basicHigher) * 0.4) + ((grossIncome - personalReduction) / 2);
            }
            else if (grossIncome > higherAdditional)
            {
                tax = ((basicHigher - personalBasic) * 0.2) + ((higherAdditional - basicHigher) * 0.4) + ((higherAdditional - personalReduction) / 2) + ((grossIncome - higherAdditional) * 0.45);
            }
            double netIncome = grossIncome - tax;
            Console.WriteLine("Gross income: " + grossIncome);
            Console.WriteLine("Tax: " + tax);
            Console.WriteLine("Net income: " + netIncome);
        }
    }
}
