class Activity 
{
    protected string _activityName;

    protected int _duration = 0;

    public void Welcome(string name)
    {
        _activityName = name;
        Console.WriteLine($"Welcome to the {_activityName} activity!");
    }

    public void SetDuration()
    {
        Console.Write("How long, in seconds, would you like to participate in this activity? ");
        _duration = int.Parse(Console.ReadLine());

        Console.Clear();

        Console.WriteLine("Get ready...");
        this.Spinner();
    }


    public void Bye()
    {
        Console.WriteLine("Well done!!");
        this.Spinner();
        Console.WriteLine("");
        Console.WriteLine($"You have completed another {_duration} seconds of the {_activityName} activity!");
        this.Spinner();
    }

    //Below are the spinner and Countdown functions

    public void Spinner()
    {
        Console.Write("|");
        Thread.Sleep(500);
        Console.Write("\b \b"); // Erase the + character
        Console.Write("/");
        Thread.Sleep(500);
        Console.Write("\b \b");
        Console.Write("-");
        Thread.Sleep(500);
        Console.Write("\b \b");
        Console.Write("\\");
        Thread.Sleep(500);
        Console.Write("\b \b");
        Console.Write("|");
        Thread.Sleep(500);
        Console.Write("\b \b");
        Console.Write("/");
        Thread.Sleep(500);
        Console.Write("\b \b");
        Console.Write("-");
        Thread.Sleep(500);
        Console.Write("\b \b");
        Console.Write("\\");
        Thread.Sleep(500);
        Console.Write("\b \b");
    }



    public void CountDown(int count)
    {
        while (count != 0)
        {
            Console.Write(count);
            Thread.Sleep(1000);
            Console.Write("\b \b");
            count --;
        }
    }

}