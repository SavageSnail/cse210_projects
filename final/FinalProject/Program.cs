using System;

class Program
{
    static void Main(string[] args)
    {
        Quiz quiz = new Quiz();
        Gadgets gadget = new Gadgets();
        QuestionBank questionBank = new QuestionBank();
        int menuChoice = 0;

        while (menuChoice != 4)
        {
            Console.Clear();
            Console.WriteLine("Welcome to Mandatory Fun Trivia!!");
            Console.WriteLine("Please select an option below:");
            Console.WriteLine("");
            Console.WriteLine("1. Classic Mode");
            Console.WriteLine("2. Timed Trial");
            Console.WriteLine("3. Check Your Score");
            Console.WriteLine("4. Quit");

            Console.Write("Pick a mode, any mode: ");
            menuChoice = int.Parse(Console.ReadLine());

            if (menuChoice == 1)
            {
                quiz.MakeDaBank();
                quiz.AskQuestion();
            }

            else if (menuChoice == 2)
            {

            }

            else if (menuChoice == 3)
            {
                quiz.ShowScore();
                gadget.Spinner();
            }

            else if (menuChoice <1 || menuChoice > 4)
            {
                Console.WriteLine($"{menuChoice} is not a valid option, please choose from the list provided.");
            }

            else
            {
                Console.WriteLine("Have a great day!");
            }
        }

    }
}