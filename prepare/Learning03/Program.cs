using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Learning03 World!");

        Fraction fraction = new Fraction();
        Fraction fraction2 = new Fraction(6);
        Fraction fraction3 = new Fraction(6, 7);

        Console.WriteLine(fraction.GetTopNumber());
        Console.WriteLine(fraction.GetBottomNumber());

        Console.WriteLine(fraction2.GetTopNumber());
        Console.WriteLine(fraction2.GetBottomNumber());

        Console.WriteLine(fraction3.GetTopNumber());
        Console.WriteLine(fraction3.GetBottomNumber());

        fraction.SetTopNumber(8);
        fraction.SetBottomNumber(11);
        Console.WriteLine(fraction.GetTopNumber());
        Console.WriteLine(fraction.GetBottomNumber());

        Fraction testFraction = new Fraction(3, 4);
        Console.WriteLine(testFraction.GetFractionString());
        Console.WriteLine(testFraction.GetDecimalValue());

        Console.WriteLine(fraction3.GetDecimalValue());

    }
}