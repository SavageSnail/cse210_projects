using System;

class Program
{
    static void Main(string[] args)
    {

        Fraction userNum = new Fraction();

        Console.WriteLine($"{userNum.GetFractionString()}, or {userNum.GetDecimalValue()}");

        //tried to make my own method as a stretch challenge
        userNum.MakeAFraction();
    }
}