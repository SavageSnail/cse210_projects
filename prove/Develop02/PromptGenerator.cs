using System.Collections;
using System.Security.Cryptography.X509Certificates;


public class PromptGen 
//a class for generating prompts, I made this to keep all this code out of the way
{
    public List<string> _prompts = new List<string>();

    public string _generated;
    public Random randomGenerator = new Random();
    /*
    public string generator()
        {
            int _promptChoice = randomGenerator.Next(0,10);
            string _generated = (_prompts[_promptChoice]);
            return _generated;
        }
    */
    public string DisplayPrompt()
    {

        //my list of prompts
        _prompts.Add("Who had the biggest impact on your day today?");
        _prompts.Add("What was your favorite part of today?");
        _prompts.Add("Where was the best place you went today?");
        _prompts.Add("What did you learn from today?");
        _prompts.Add("If you could go back, what would you have done differently today?");
        _prompts.Add("What was the most exciting thing to happen today?");
        _prompts.Add("What do you wish you made more time for today?");
        _prompts.Add("What did you learn from today?");
        _prompts.Add("Was there anything that happened today that's never happened before?");
        _prompts.Add("What are you grateful for today?");

        //pick one & display it
        int _promptChoice = randomGenerator.Next(0,10);
        string _generated = (_prompts[_promptChoice]);
        
        return _generated;
        /* Trial and error stuff
        Console.WriteLine(_prompts[_promptChoice]); 

        string _generated()
        {
            int _promptChoice = randomGenerator.Next(0,10);
            return (_prompts[_promptChoice]);
        }
        */
    }
}