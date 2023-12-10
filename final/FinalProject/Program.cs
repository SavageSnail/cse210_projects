using System;
using System.Reflection.Metadata;

class Program
{
    static void Main(string[] args)
    {
        // instances of everything I'll need
        QuestionBank questionBank = new QuestionBank();
        //I left the bank classes up here so that there wouldn't be repeat questions between game modes
        NormieBank normieBank = new NormieBank();
        NerdBank nerdBank = new NerdBank();
        //Can keep track of score between modes!
        Scoreboard scoreboard = new Scoreboard();
        Quiz quiz = new Quiz(questionBank, scoreboard);
        TimedQuiz timedQuiz = new TimedQuiz(questionBank, scoreboard);
        Gadgets gadget = new Gadgets();
        int menuChoice = 0;

        //main menu
        while (menuChoice != 5)
        {
            Console.Clear();
            Console.WriteLine("Welcome to Mandatory Fun Trivia!!");
            Console.WriteLine("Please select an option below:");
            Console.WriteLine("");
            Console.WriteLine("1. Classic Mode");
            Console.WriteLine("2. Timed Trial");
            Console.WriteLine("3. Check Your Score");
            Console.WriteLine("4. Reset Question Banks");
            Console.WriteLine("5. Quit");

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
                    Console.WriteLine("Normal stuff it is!");
                    Console.Write("Getting the quiz ready... ");
                    gadget.Spinner();
                    //grab the "normie" question bank to pull from
                    Quiz normieQuiz = new Quiz(normieBank, scoreboard);

                    normieQuiz.AskQuestion();
                }

                else if (userChoice == 2)
                {
                    Console.WriteLine("Halo stuff it is!");
                    Console.Write("Getting the quiz ready... ");
                    gadget.Spinner();
                    // grab the "nerd" question bank to pull from
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
                gadget.TypeLine(timedQuiz.Intro());

                //from here, same setup as a regular quiz
                Console.WriteLine("\n What category would you like to play? ");
                Console.WriteLine("1. General  OR  2. Halo: ");
                int userChoice = int.Parse(Console.ReadLine());

                if (userChoice == 1)
                {
                    Console.WriteLine("Normal stuff it is!");
                    Console.Write("Getting the quiz ready... ");
                    gadget.Spinner();
                    //grab the "normie" question bank to pull from
                    TimedQuiz normieQuiz = new TimedQuiz(normieBank, scoreboard);

                    normieQuiz.AskQuestion();
                }

                else if (userChoice == 2)
                {
                    Console.WriteLine("Halo stuff it is!");
                    Console.Write("Getting the quiz ready... ");
                    gadget.Spinner();
                    // grab the "nerd" question bank to pull from
                    TimedQuiz nerdQuiz = new TimedQuiz(nerdBank, scoreboard);

                    nerdQuiz.AskQuestion();
                }

                else
                {
                    Console.WriteLine("Oops, that wasn't an option!");
                    Console.Write("Restarting... ");
                    gadget.CountDown(4);
                }
            }

            else if (menuChoice == 3)
            {
                Console.WriteLine(quiz.ShowScore());
                gadget.Spinner();
            }

            else if (menuChoice == 4)
            {
                //in case the user wants to keep their score and retry the quizes once the questions have been exhausted
                Console.WriteLine("\nWhich bank would you like to reset? \n1. General Trivia, 2. Halo Trivia, OR 3. Both");
                Console.WriteLine("You can also press 4 just to reset your score.");
                Console.WriteLine("(Any other number to go back): ");
                int reset = int.Parse(Console.ReadLine());
                if (reset == 1)
                {
                    normieBank.CompileQuestions();
                    Console.Write("Restocking bank... ");
                    gadget.Spinner();
                }

                else if (reset == 2)
                {
                    nerdBank.CompileQuestions();
                    Console.Write("Restocking bank... ");
                    gadget.Spinner();
                }

                else if (reset == 4)
                {
                    Console.Write("resetting score... ");
                    gadget.Spinner();
                }

                else if (reset < 1 || reset > 4)
                {
                    Console.Write("Oops! wrong key. Returning to menu... ");
                    gadget.CountDown(4);
                }

                else
                {
                normieBank.CompileQuestions();
                nerdBank.CompileQuestions();
                Console.Write("Restocking bank... ");
                gadget.Spinner();
                }
            }

            else if (menuChoice <1 || menuChoice > 5)
            {
                Console.WriteLine($"{menuChoice} is not a valid option, please choose from the list provided.");
                gadget.Spinner();
            }

            else
            {
                Console.WriteLine("\nThanks for playing!");
            }
        }

    }
}