using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction FractionOne = new Fraction();
        Console.WriteLine(FractionOne.GetFraction());
        Console.WriteLine(FractionOne.GetDecimal());

        Fraction FractionTwo = new Fraction(5);
        Console.WriteLine(FractionTwo.GetFraction());
        Console.WriteLine(FractionTwo.GetDecimal());

        Fraction FractionThree = new Fraction(3, 4);
        Console.WriteLine(FractionThree.GetFraction());
        Console.WriteLine(FractionThree.GetDecimal());

        Fraction FractionFour = new Fraction(1, 3);
        Console.WriteLine(FractionFour.GetFraction());
        Console.WriteLine(FractionFour.GetDecimal());
    }
}