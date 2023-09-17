using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string valueFromUser = Console.ReadLine();

        int x = int.Parse(valueFromUser);

        if (x >= 90)
        {
            Console.WriteLine("A");
        }
        else if (x >=80)
        {
            Console.WriteLine("B");
        }
        else if (x >= 70)
        {
            Console.WriteLine("C");
        }
        else if (x >=60)
        {
            Console.WriteLine("D");
        }
        else
        {
            Console.WriteLine("F");
        }

        if (x >= 70)
        {
            Console.WriteLine("Congratulations! You passed!");
        }

        else 
        {
            Console.WriteLine("Oof. Try again next semester!");
        }

    }
}