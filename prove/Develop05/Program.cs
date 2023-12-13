using System;
using System.IO;

class Program
{
    static void Main(string[] args)
    {
        NewGoal newGoal = new NewGoal();
        int points = 0;
        int menuChoice = 0;
        string filename;

        List<Goal> goals = new List<Goal>();

        while (menuChoice != 6)
        {
            Console.WriteLine("\n \n");
            Console.WriteLine($"\nYou have {points} points\n");
            Console.WriteLine("Welcome!");
            Console.WriteLine("1. Create new goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("\nPlease choose an option: ");
            menuChoice = int.Parse(Console.ReadLine());


            if (menuChoice == 1)
            {
                goals.Add(newGoal.MakeGoal());
                // SimpleGoal simpleGoal = new SimpleGoal("test", "A testing goal", 3);
                // Console.WriteLine(simpleGoal.GetStringRepresentation());
                // Thread.Sleep(5000);
            }

            else if (menuChoice == 2)
            {
                foreach (Goal goal in goals)
                {
                    if (goal.GetName() == "CheckList")
                    {
                        goal.IsCompleted();
                        Console.Write(goal.GetName());
                        Console.Write($" ({goal.GetDescription()}) - Currently completed: {goal.GetCheck()}/{goal.GetLimit()}\n");
                    }

                    else
                    {
                        goal.IsCompleted();
                        Console.Write(goal.GetName());
                        Console.Write($" ({goal.GetDescription()})\n");
                    }
                }
                Thread.Sleep(5000);
            }

            else if (menuChoice == 3)
            {
                Console.WriteLine("What would you like to name the file?: ");
                string saveFile = Console.ReadLine();

                using (StreamWriter outputFile = new StreamWriter(saveFile))
                {
                    // You can add text to the file with the WriteLine method
                    outputFile.WriteLine($"Score/{points}");
                    foreach (Goal goal in goals)
                    {
                        outputFile.WriteLine(goal.GetStringRepresentation());
                    }
                }
            }

            else if (menuChoice == 4)
            {
                Console.WriteLine("What is the name of the file you would like to load?: ");
                filename = Console.ReadLine();
                string[] lines = System.IO.File.ReadAllLines(filename);

                foreach (string line in lines)
                {

                string[] parts = line.Split("/");

                string type = parts[0];
                string name = parts[1];
                
                
                if (type == "Score")
                {
                    points = int.Parse(name);
                }

                else if (type == "Simple")
                {
                    string description = parts[2];
                    string earnable = parts[3];
                    string checks = parts[4];
                    goals.Add(new SimpleGoal(name, description, int.Parse(earnable), Convert.ToBoolean(checks)));
                }

                else if (type == "Eternal")
                {
                    string description = parts[2];
                    string earnable = parts[3];
                    goals.Add(new EternalGoal(name, description, int.Parse(earnable)));
                }

                else if (type == "CheckList")
                {
                    string description = parts[2];
                    string earnable = parts[3];
                    string checks = parts[4];
                    string bonus = parts[5];
                    string limit = parts[6];
                    goals.Add(new CheckListG(name, description, int.Parse(earnable), int.Parse(checks), int.Parse(bonus), int.Parse(limit)));
                }

                }
            }

            else if (menuChoice == 5)
            {
                int eventChoice = 0;
                foreach (Goal goal in goals)
                {
                    eventChoice ++;
                    Console.Write($"{eventChoice}. ");
                    Console.WriteLine(goal.GetName());
                }
                
                Console.Write("Which goal have you completed?: ");
                int achieved = int.Parse(Console.ReadLine()) -1;

                Goal finished = goals[achieved];

                if (finished.GetName() == "CheckList")
                {
                    finished.CompleteGoal();
                    Console.WriteLine("Great job!!");
                    if (finished.IsCompleted())
                    {
                        Console.WriteLine($"Points Earned: {finished.GetBonus()}");
                        points = points + finished.GetBonus();
                    }
                    else
                    {
                        Console.WriteLine($"Points Earned: {finished.GetPoints()}");
                        points = points + finished.GetPoints();
                    }
                }

                else if (finished.GetName() == "Simple")
                {
                    finished.CompleteGoal();
                    Console.WriteLine("Great Job!!");
                    Console.WriteLine($"Points Earned: {finished.GetPoints}");
                    points = points + finished.GetPoints();
                }

                else
                {
                    Console.WriteLine("Great Job!!");
                    Console.WriteLine($"Points Earned: {finished.GetPoints}");
                    points = points + finished.GetPoints();
                }
            }

            else if (menuChoice <1 || menuChoice > 6)
            {
                Console.WriteLine("\nSorry, that wasn't an option.");
                Thread.Sleep(3000);
            }

            else 
            {
                Console.WriteLine("\nHave a great day!\n");
            }

        }
    }   
}