class Reflection: Activity
{
    public string SetDescript()
    {
        return _description = "This activity will help you reflect on times in your life that you have shown strength and resiliance. This will help you recognize the power you have and how you can use it in other aspects of your life.";
    }

    List<string> _prompts = new List<string>()
    {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."
    };

    List<string> _questions = new List<string>()
    {
        "Why was this experience meaningful to you?",
        "Have you ever done anything like this before?",
        "How did you get started?",
        "How did you feel when it was complete?",
        "What made this time different than other times when you were not as successful?",
        "What is your favorite thing about this experience?",
        "What could you learn from this experience that applies to other situations?",
        "What did you learn about yourself through this experience?",
        "How can you keep this experience in mind in the future?",
    };

    public void GetPrompt()
    {
        Random random = new Random();
        int pick = random.Next(0,_prompts.Count);
        string prompt = _prompts[pick];
        Console.WriteLine("Consider the follwoing prompt:");
        Console.WriteLine(prompt);
        Console.Write("When you have something in mind, press 'enter' to continue: ");
        Console.ReadLine();
        Console.Write("Now, with that situation in mind, consider the following questions: ");
        base.CountDown(4);
        Console.Clear();
        Console.WriteLine($"-----{prompt}----- \n");

    }
    
    public void Run()
    {
        DateTime start = DateTime.Now;
        List<string> unPicked = new List<string>();

        foreach (string q in _questions)
        {
            unPicked.Add(q);
        }

        while ((DateTime.Now - start).TotalSeconds < _duration)
        {
            Random random = new Random();
            int pick = random.Next(0, unPicked.Count);
            string question = unPicked[pick];
            Console.WriteLine(question);
            base.Spinner();
            base.Spinner();
            Console.WriteLine(" ");
            unPicked.Remove(question);
        }
    }
}