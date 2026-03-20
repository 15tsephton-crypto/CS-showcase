using System;
namespace Tax
{
    class TaxCalc
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your gross income: ");
            double grossIncome = double.Parse(Console.ReadLine()!);
            Calc(grossIncome);
        }
        static void Calc(double grossIncome)
        {
            double tax = 0;
            if (grossIncome > 12570 && grossIncome <= 50270)
            {
                tax = (grossIncome - 12570) * 0.2;
            }
            else if (grossIncome > 50270 && grossIncome <= 100000)
            {
                tax = 7540 + ((grossIncome - 50270) * 0.4);
            }
            else if (grossIncome > 100000 && grossIncome <= 125140)
            {
                tax = 7540 + ((grossIncome - 50270) * 0.4) + ((grossIncome - 100000) / 2);
            }
            else if (grossIncome > 125140)
            {
                tax = 7540 + 29948 + 12570 + ((grossIncome - 125140) * 0.45);
            }
            double netIncome = grossIncome - tax;
            Console.WriteLine("Gross income: " + grossIncome);
            Console.WriteLine("Tax: " + tax);
            Console.WriteLine("Net income: " + netIncome);
        }
    }
}