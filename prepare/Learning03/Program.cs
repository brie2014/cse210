using System;

class Program
{
    static void Main(string[] args)
    {
        // Setters and getters work
        Fraction setAndGetFraction = new(8, 13);
        setAndGetFraction.SetNumerator(5);
        setAndGetFraction.SetDenominator(10);
        Console.WriteLine(setAndGetFraction.GetNumerator()); //Should be 5
        Console.WriteLine(setAndGetFraction.GetDenominator()); //Should be 10

        //Returns string and decimal values for fractions
        // And test that constructors can handle different scenarios
        Fraction fraction1 = new();
        PrintFractionStringAndDecimal(fraction1); // 1/1 and 1
        Fraction fraction2 = new(5);
        PrintFractionStringAndDecimal(fraction2); // 5/1 and 5
        Fraction fraction3 = new(3, 4);
        PrintFractionStringAndDecimal(fraction3); // 3/4 and 0.75
        Fraction fraction4 = new(1, 3);
        PrintFractionStringAndDecimal(fraction4); // 1/3 and 0.3333333


    }

    static void PrintFractionStringAndDecimal(Fraction fraction)
    {
        Console.WriteLine(fraction.GetFractionString());
        Console.WriteLine(fraction.GetDecimalValue());
    }
}