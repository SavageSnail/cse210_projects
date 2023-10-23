using System;
using System.Net.Quic;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {

        Scripture scrip = new Scripture("For God so loved the world that He gave His only begotten son, that whosoever...");

        Reference reference = new Reference("John", "3", "16");

        ConsoleSpiner spin = new ConsoleSpiner();

        Console.Write($"{reference.GetRenderedText()} ");
        scrip.GetRenderedText();
        Console.WriteLine();

        string userInput = Console.ReadLine();

        Console.Clear();

        while (userInput != "quit")
        {
            scrip.HideWords();


            Console.Write("Hiding....");

            // adding a little style
            Stopwatch s = new Stopwatch();
            s.Start();
            while (s.Elapsed < TimeSpan.FromSeconds(2)) 
            {
                spin.Turn();
            }
            s.Stop();

            Console.Clear();

            Console.Write($"{reference.GetRenderedText()} ");
            scrip.GetRenderedText();
            Console.WriteLine();

            userInput = Console.ReadLine();

            Console.Clear();

            if (scrip.IsCompletelyHidden())
            {
                break;
            }
        }

    }
}