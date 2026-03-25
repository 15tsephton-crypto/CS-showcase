using System;
namespace Tax
{
    class TaxCalc
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your gross income:");
            double grossIncome = double.Parse(Console.ReadLine()!);
            Console.WriteLine("Do you pay Scottish income tax? (y/n)");
            string scottish = Console.ReadLine()!;
            if (scottish == "y")
            {
                ScotCalc(grossIncome);
            }
            else
            {
                UKCalc(grossIncome);
            }
        }
        static void UKCalc(double grossIncome)
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
        static void ScotCalc(double grossIncome)
        {
            double personalStarter = 12570; // The bound between the personal allowance and the starter rate.
            double starterBasic = 15397; // The bound between the starter rate and the basic rate.
            double basicIntermediate = 27491; // The bound between the basic rate and the intermediate rate.
            double intermediateHigher = 43662; // The bound between the intermediate rate and the higher rate.
            double higherAdvanced = 75000; // The bound between the higher rate and the advanced rate.
            double advancedTop = 125140; // The bound between the advanced rate and the top rate.
            double personalReduction = 100000; // The point a which the personal allowance is reduced from.
            double tax = 0;
            if (grossIncome > personalStarter && grossIncome <= starterBasic)
            {
                tax = (grossIncome - personalStarter) * 0.19;
            }
            else if (grossIncome > starterBasic && grossIncome <= basicIntermediate)
            {
                tax = ((starterBasic - personalStarter) * 0.19) + ((grossIncome - starterBasic) * 0.2);
            }
            else if (grossIncome > basicIntermediate && grossIncome <= intermediateHigher)
            {
                tax = ((starterBasic - personalStarter) * 0.19) + ((basicIntermediate - starterBasic) * 0.2) + ((grossIncome - basicIntermediate) * 0.21);
            }
            else if (grossIncome > intermediateHigher && grossIncome <= higherAdvanced)
            {
                tax = ((starterBasic - personalStarter) * 0.19) + ((basicIntermediate - starterBasic) * 0.2) + ((intermediateHigher - basicIntermediate) * 0.21) + ((grossIncome - intermediateHigher) * 0.42);
            }
            else if (grossIncome > higherAdvanced && grossIncome <= personalReduction)
            {
                tax = ((starterBasic - personalStarter) * 0.19) + ((basicIntermediate - starterBasic) * 0.2) + ((intermediateHigher - basicIntermediate) * 0.21) + ((higherAdvanced - intermediateHigher) * 0.42) + ((grossIncome - higherAdvanced) * 0.45);
            }
            else if (grossIncome > personalReduction && grossIncome <= advancedTop)
            {
                tax = ((starterBasic - personalStarter) * 0.19) + ((basicIntermediate - starterBasic) * 0.2) + ((intermediateHigher - basicIntermediate) * 0.21) + ((higherAdvanced - intermediateHigher) * 0.42) + ((grossIncome - higherAdvanced) * 0.45) + ((grossIncome - personalReduction) / 2);
            }
            else if (grossIncome > advancedTop)
            {
                tax = ((starterBasic - personalStarter) * 0.19) + ((basicIntermediate - starterBasic) * 0.2) + ((intermediateHigher - basicIntermediate) * 0.21) + ((higherAdvanced - intermediateHigher) * 0.42) + ((advancedTop - higherAdvanced) * 0.45) + ((advancedTop - personalReduction) / 2) + ((grossIncome - advancedTop) * 0.48);
            }
            double netIncome = grossIncome - tax;
            Console.WriteLine("Gross income: " + grossIncome);
            Console.WriteLine("Tax: " + tax);
            Console.WriteLine("Net income: " + netIncome);
        }
    }
}
