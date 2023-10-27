using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning04 World!");

        Assignment hw1 = new Assignment("Johnny Bravo", "History");
        Console.WriteLine(hw1.GetSummary());

        //MATH
        Math hw2 = new Math("Johnny Bravo", "Math", "Division", "5");

        Console.WriteLine(hw2.GetSummary());
        Console.WriteLine(hw2.GetHWList());

        //Writing
        Writing hw3 = new Writing("Johnny B", "Writing", "To Kill a Mockingbird");
        Console.WriteLine(hw3.GetSummary());
        Console.WriteLine(hw3.GetWritingInfo());
        
    }
}