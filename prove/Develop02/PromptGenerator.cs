using System.Collections;
using System.Security.Cryptography.X509Certificates;


public class PromptGen 
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
        _prompts.Add("T6");
        _prompts.Add("T7");
        _prompts.Add("T8");
        _prompts.Add("T9");
        _prompts.Add("T10");

        //pick one & display it
        int _promptChoice = randomGenerator.Next(0,10);
        string _generated = (_prompts[_promptChoice]);
        
        return _generated;

        /*
        //a generator to pick one at random, then print it
        Random randomGenerator = new Random();
        int _promptChoice = randomGenerator.Next(0,10);

        Console.WriteLine(_prompts[_promptChoice]); 

        string _generated()
        {
            int _promptChoice = randomGenerator.Next(0,10);
            return (_prompts[_promptChoice]);
        }
        */
    }
}