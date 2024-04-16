using System;

public class CompoundInterestCalculator
{
    public static void Main(string[] args)
    {
        double principal = 1000;
        double rate = 0.05;
        int years = 5;

        Func<double, double> compoundInterest = p => p * Math.Pow(1 + rate, years);

        double result = CalculateCompoundInterest(principal, compoundInterest);
        Console.WriteLine("Compound interest after " + years + " years: " + result);
    }

    public static double CalculateCompoundInterest(double principal, Func<double, double> interestFunction)
    {
        return interestFunction(principal);
    }
}
