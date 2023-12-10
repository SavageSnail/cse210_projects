class Gadgets
{
    //here's a class of all the cool stuff I can use throughout the rest of the program
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

    public void TypeLine(string text)
    {
        foreach (var character in text)
        {
            Console.Write(character);
            Thread.Sleep(30);
        }
    }

    public void BlinkWord(string word)
    {
        Console.Clear();
        Console.Write(word);
        Thread.Sleep(300);
        Console.Clear();
        Thread.Sleep(200);
        Console.Write(word);
        Thread.Sleep(300);
        Console.Clear();
        Thread.Sleep(200);
        Console.Write(word);
        Thread.Sleep(500);
    }
}