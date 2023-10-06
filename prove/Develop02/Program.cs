using System;

class Program
{
    static void Main(string[] args)
    {
        int menu_choice = 6;

        //Containts the main menu, will repeat unitl asked to leave.
        while (menu_choice != 5)
        {
            Console.WriteLine("Welcome to the journal program!");
            Console.WriteLine("Please select one of the following:");

            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");
            Console.WriteLine(" ");

            Console.Write("What would you like to do? ");
            menu_choice = int.Parse(Console.ReadLine());

            if (menu_choice == 1) 
            {
                PromptGen newPrompt = new PromptGen();
                newPrompt._generated = newPrompt.DisplayPrompt();
                Console.WriteLine(newPrompt._generated);
                

                Write newEntry = new Write();
                newEntry._userInput = Console.ReadLine();
                newEntry.theCurrentTime = DateTime.Now;


                //Console.WriteLine($"{newEntry.theCurrentTime}- {newPrompt._generated}:" + '\n' + $"{newEntry._userInput}");

                using (StreamWriter journalEntry = new StreamWriter(newEntry._userInput))
                {
                    journalEntry.WriteLine($"{newEntry.theCurrentTime}- {newPrompt._generated}:" + '\n' + $"{newEntry._userInput}");
                }
                
            }

            else if (menu_choice == 2)
            {

            }

            else if (menu_choice == 3)
            {

            }

            else if (menu_choice ==4)
            {

            }
            //tried to add a part here to prompt the user if their choice wasn't a listed option
            
            else if (menu_choice > 5)
            {
                Console.WriteLine("Sorry, that wasn't an option listed.");
                Console.WriteLine("Please choose an option listed: ");
                Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
            }
            

            else
            {
                Console.WriteLine("Have a great day!");
            }


        }
       
    }
}