using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your grade percentage? ");
        string valueFromUser = Console.ReadLine();

        int x = int.Parse(valueFromUser);
        string letter = ("Test");

        
        if (x >= 90)
        {
            letter = ("A");
        }
        else if (x >=80)
        {
            letter = ("B");
        }
        else if (x >= 70)
        {
             letter = ("C");
        }
        else if (x >=60)
        {
             letter = ("D");
        }
        else
        {
             letter = ("F");
        }

        Console.WriteLine($"You've earned an {letter}!");

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