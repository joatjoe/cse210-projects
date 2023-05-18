using System;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction01 = new Fraction();
        Console.WriteLine(fraction01.GetFractionString());
        Console.WriteLine(fraction01.GetDecimalValue());

        Fraction fraction02 = new Fraction(5);
        Console.WriteLine(fraction02.GetFractionString());
        Console.WriteLine(fraction02.GetDecimalValue());

        Fraction fraction03 = new Fraction(3, 4);
        Console.WriteLine(fraction03.GetFractionString());
        Console.WriteLine(fraction03.GetDecimalValue());

        Fraction fraction04 = new Fraction(1, 3);
        Console.WriteLine(fraction04.GetFractionString());
        Console.WriteLine(fraction04.GetDecimalValue());
    }
}