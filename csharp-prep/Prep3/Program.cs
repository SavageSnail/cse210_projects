using System;

class Program
{
    static void Main(string[] args)
    {
       
        int guess = -1;

        Random randomGenerator = new Random();
        int magic = randomGenerator.Next(1, 101);
        
        
    while (guess != magic)
    {

        Console.Write("What is your guess? ");
        string userGuess = Console.ReadLine();

        guess = int.Parse(userGuess);


        if (guess > magic)
        {
            Console.WriteLine("Lower");
          
        }

        else if (guess < magic)
        {
            Console.WriteLine("Higher");
        }

        else
        {
            Console.WriteLine("You guessed Right!");
        }
    }



   


     }
}