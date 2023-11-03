class Breathing: Activity 
{
    private int _inTime;
    private int _outTime;

    //Made a function to give the user the choice of whether or not they'd like to set their own in/out times
    public void SetTimes()
    {
        //I made the "get ready" part of the program part of setting duration, so I had to backtrack a little:
        Console.WriteLine("Oh wait!"); // #comedy
        Console.WriteLine("Would you like to set your own breath in/out times?"); 
        Console.Write("type '1' for yes, 2 for no: ");
        int pick = int.Parse(Console.ReadLine());
        Console.WriteLine("");
        //if they set it
        if (pick == 1)
        {
            Console.Write("Seconds to Breath in: ");
            _inTime = int.Parse(Console.ReadLine());
            Console.Write("Seconds to breath out: ");
            _outTime = int.Parse(Console.ReadLine());
        }
        // if they don't care
        else
        {
            _inTime = 5;
            _outTime = 6;
        }

        Console.Write("Ok, for reals this time... "); // 
        base.CountDown(3);
        Console.Clear();
    }

    public void Breath()
    {
        DateTime startTime = DateTime.Now;
        //int finishTime = _duration;

        while ((DateTime.Now - startTime).TotalSeconds < _duration)
        {
            Console.Write($"Breath in... ");
            base.CountDown(_inTime);
            Console.WriteLine(" ");
            Console.Write("Breath out... ");
            base.CountDown(_outTime);
            Console.WriteLine(" ");
            Console.WriteLine(" ");
        }
    }
}