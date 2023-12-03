class Gadgets
{
    public void Spinner()
    {
        Console.Write("|");
        Thread.Sleep(400);
        Console.Write("\b \b");
        Console.Write("/");
        Thread.Sleep(400);
        Console.Write("\b \b");
        Console.Write("-");
        Thread.Sleep(400);
        Console.Write("\b \b");
        Console.Write("\\");
        Thread.Sleep(400);
        Console.Write("\b \b");
        Console.Write("|");
        Thread.Sleep(400);
        Console.Write("\b \b");
        Console.Write("/");
        Thread.Sleep(400);
        Console.Write("\b \b");
        Console.Write("-");
        Thread.Sleep(400);
        Console.Write("\b \b");
        Console.Write("\\");
        Thread.Sleep(400);
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