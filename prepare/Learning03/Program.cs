using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction FractionOne = new Fraction();
        Console.WriteLine(FractionOne.GetFractionString());
        Console.WriteLine(FractionOne.GetDecimalValue());

        Fraction FractionTwo = new Fraction(5);
        Console.WriteLine(FractionTwo.GetFractionString());
        Console.WriteLine(FractionTwo.GetDecimalValue());

        Fraction FractionThree = new Fraction(3, 4);
        Console.WriteLine(FractionThree.GetFractionString());
        Console.WriteLine(FractionThree.GetDecimalValue());

        Fraction FractionFour = new Fraction(1, 3);
        Console.WriteLine(FractionFour.GetFractionString());
        Console.WriteLine(FractionFour.GetDecimalValue());
    }
}