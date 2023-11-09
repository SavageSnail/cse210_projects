using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Develop04 World!");

        Stopwatch watch = new Stopwatch();
        Breathing breathing = new Breathing();
        Reflection reflection = new Reflection();
        Listing listing = new Listing();

        int userChoice = 0;

        do
        {
            Console.Clear();

            Console.WriteLine("Menu Options:");
            Console.WriteLine("   1. Start: Breathing Activity");
            Console.WriteLine("   2. Start: Reflecting Activity");
            Console.WriteLine("   3. Start: Listing Activity");
            Console.WriteLine("   4. Quit");
            Console.Write("Please select an option: ");
            userChoice = int.Parse(Console.ReadLine());

            if (userChoice == 1)
            {
                breathing.SetDescript();
                breathing.Welcome("breathing");
                breathing.SetDuration();
                breathing.SetTimes();
                breathing.Breath();
                breathing.Bye();
            }

            else if (userChoice == 2)
            {
                reflection.SetDescript();
                reflection.Welcome("reflection");
                reflection.SetDuration();
                reflection.GetPrompt();
                reflection.Run();
                reflection.Bye();
            }

            else if (userChoice == 3)
            {
                listing.SetDescript();
                listing.Welcome("listing");
                listing.SetDuration();
                listing.GetPrompt();
                listing.Run();

                listing.Bye();
            }

            else if (userChoice > 4 || userChoice <1)
            {
                Console.WriteLine(" ");
                Console.WriteLine($"{userChoice} is not an available option. Please choose a menu item:");
                Thread.Sleep(3500);

            } 
            else 
            {
                Console.WriteLine("Have a great day!");
            }
            
        } while (userChoice != 4);
    }
}