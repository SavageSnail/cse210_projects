class Scoreboard
{
    private int score = 0;
    Gadgets gadget = new Gadgets();

    public int GetUserInput()
    {
        Console.Write("Answer: ");
        return int.Parse(Console.ReadLine());
    }

    public void EarnPoint(Question question, int userChoice)
    {
        int _correct = question._correctIndex +1;

        if (_correct == userChoice)
        {
            Console.WriteLine("Correct! Score: +1");
            score++;
            Console.WriteLine($"New Score: {score}");
            gadget.Spinner();

        }
        else
        {
            Console.WriteLine($"WRONG!! The correct answer is #{_correct}. Better luck next time!");
            Console.WriteLine($"Score: {score}");
            gadget.Spinner();
        }
    }

    public void ShowScore()
    {
        Console.WriteLine($"Your current score is: {score}");
    }


}