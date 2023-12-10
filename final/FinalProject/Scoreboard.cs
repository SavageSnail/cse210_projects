class Scoreboard
{
    // keeps track of score, and checks answers
    private int score = 0;
    Gadgets gadget = new Gadgets();

    public int GetUserInput()
    {
        Console.Write("Answer: ");
        return int.Parse(Console.ReadLine());
    }

    public void EarnPoint(Question question, int userChoice)
    {
        //adjust to match user input
        int _correct = question.GetIndex() +1;

        if (_correct == userChoice)
        {
            Console.WriteLine("Correct! Score: +1");
            score++;
            Console.WriteLine($"New Score: {score}");
            gadget.Spinner();

        }
        else
        {
            //had to be a little mean to raise the stakes a bit haha
            Console.WriteLine($"WRONG!! The correct answer is #{_correct}. Better luck next time!");
            Console.WriteLine($"Score: {score}");
            gadget.Spinner();
        }
    }

    //this is for the timed quiz to add the score there to the total score
    public void AddScore(int addedscore)
    {
        score = score + addedscore;
    }

    public string ShowScore()
    {
        return $"Your current score is: {score}";
    }


}