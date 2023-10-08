using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;

class Program
{
    static void Main(string[] args)
    {
        // PLEASE READ!!!!   -- So, for the life of me, I COULD NOT figure out how to save the list made in option 1 to the overall list. 
        // I thought being able to do that would make everything else work really smoothly. But, I couldn't figure out how to save information obtained inside an "if" statement
        // I can move the "SaveToFile" method to be a part of option 1, but then I wouldn't really know what option 4 would exist for. 
        // I apologize for the lack of functionality, because without being able to save what you write the rest doesn't really work too well...
        // Besides that one big issue, I think the program here would run pretty smoothly overall (?) but there definitely would be some issues to work out
        // But I didn't get the chance to work them out because of the first big problem I mentioned
        // I put a lot of work into this, but I'm sorry I didn't have enough time to solve the main issue :( 
        // please look around! and PLEASE let me know how to fix this problem IT'S DRIVING ME CRAZY lol
        
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
            Console.WriteLine("Instructor, please read top of code :)");

            Console.Write("What would you like to do? ");
            menu_choice = int.Parse(Console.ReadLine());

            Journal Overall = new Journal();
            Overall._openFile = "journal.txt";
            //Overall._entries = new List<Write>();

            if (menu_choice == 1) 
            // Generate a prompt, get user's input, add to overall list
            {
                PromptGen newPrompt = new PromptGen();
                newPrompt._generated = newPrompt.DisplayPrompt();
                Console.WriteLine(newPrompt._generated);
                

                Write newEntry = new Write();

                newEntry._userInput = Console.ReadLine();
                newEntry.theCurrentTime = DateTime.Now.ToString();
                newEntry._gennedprompt = newPrompt._generated;

                Overall._entries.Add(newEntry);

                Overall.SaveToFile(Overall._entries);

                Console.WriteLine($"{newEntry.theCurrentTime}- {newEntry._gennedprompt}:" + '\n' + $"{newEntry._userInput}");

            }

            else if (menu_choice == 2)
            {
                Console.WriteLine("Reading from file...");
                Console.WriteLine(" ");

                string filename = Overall._openFile;
                string[] lines = System.IO.File.ReadAllLines(filename);

                
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                //string[] parts = line.Split(",");

                //string firstName = parts[0];
                //string lastName = parts[1];
                }
                
                /*
                foreach (Write entry in Overall._entries){
                    Console.WriteLine(entry._userInput);
                } */
            }

            else if (menu_choice == 3)
            {
                Console.WriteLine("What file would you like to open?");
                Overall._openFile = Console.ReadLine();
            }

            else if (menu_choice ==4)
            {
                Console.WriteLine("What is the filename?");
                Overall._openFile = Console.ReadLine();
                Console.WriteLine("Saving...");

                Overall.SaveToFile(Overall._entries);
            }

            //tried to add a part here to prompt the user if their choice wasn't a listed option
            else if ((menu_choice > 5) || (menu_choice == 0))
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