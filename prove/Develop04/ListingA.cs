using System;
using System.Diagnostics;
class Listing: Activity 
{

    private Stopwatch sw = new Stopwatch();
    private double lastFrame;
    Random random = new Random();
    private List<string> _inputs = new List<string>();

    private List<string> _prompts = new List<string>()
    {
        "Who are some people you appreciate in your life?",
        "What are personal strengths of yours?",
        "Who are people that have helped you this week?",
        "When have you felt the Holy Ghost this month?",
        "who are some of your personal heroes?",
        "What good things have happened this week?",
        "What goals are you working towards?"
    };


    private double deltaTime()
    {
        TimeSpan ts = this.sw.Elapsed;
        double firstFrame = ts.TotalMilliseconds;
        double dt = firstFrame - lastFrame;
        this.lastFrame = ts.TotalMilliseconds;
        return dt;
    }

    // get a random prompt
    public void GetPrompt()
    {
        int pick = random.Next(0,_prompts.Count);
        string prompt = _prompts[pick];
        Console.WriteLine(prompt);
    }

    // Thank you so much for helping us shell this out!!
    public void Run()
    {
        this.sw.Start();
        double acc = 0.0;
        List<string> buf = new List<string>();

        Console.WriteLine("Ready...");
        base.CountDown(3);
        Console.WriteLine("Go!");
        Thread.Sleep(1000);

        while (acc <= base._duration*1000)
        {
            acc += this.deltaTime();
            if (!Console.KeyAvailable)
            {
                continue;
            }

            ConsoleKeyInfo key = Console.ReadKey();

            if (key.Key == ConsoleKey.Enter)
            {
                Console.WriteLine("");
                buf.Add("\n");
            }
            
            else
            {
                buf.Add(key.KeyChar.ToString());
            }
        }

        Console.WriteLine("\nTime's up!");
        base.Spinner();

        string bufStr = String.Join<string>("", buf);
        Console.WriteLine($"Here's what you typed: {bufStr}");

        //int responseCount = 
        //Console.WriteLine($"Number of items listed: {responseCount}");
    }

}