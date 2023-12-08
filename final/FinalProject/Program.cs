using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        QuestionBank questionBank = new QuestionBank();
        NormieBank normieBank = new NormieBank();
        NerdBank nerdBank = new NerdBank();
        Scoreboard scoreboard = new Scoreboard();
        Quiz quiz = new Quiz(questionBank, scoreboard);
        Gadgets gadget = new Gadgets();
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

            //choose a game category
            if (menuChoice == 1)
            {
                gadget.TypeLine(quiz.Intro());

                Console.WriteLine("\n What category would you like to play? ");
                Console.WriteLine("1. General  OR  2. Halo: ");
                int userChoice = int.Parse(Console.ReadLine());

                if (userChoice == 1)
                {
                    Console.WriteLine("Normie stuff it is!");
                    Console.Write("Getting the quiz ready... ");
                    gadget.Spinner();
                    Quiz normieQuiz = new Quiz(normieBank, scoreboard);

                    normieQuiz.AskQuestion();
                }

                else if (userChoice == 2)
                {
                    Console.WriteLine("Halo stuff it is!");
                    Console.Write("Getting the quiz ready... ");
                    gadget.Spinner();
                    Quiz nerdQuiz = new Quiz(nerdBank, scoreboard);

                    nerdQuiz.AskQuestion();
                }

                else
                {
                    Console.WriteLine("Oops, that wasn't an option!");
                    Console.Write("Restarting... ");
                    gadget.CountDown(4);
                }

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