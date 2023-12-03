class Scoreboard
{
    private int score = 0;

    public int GetUserInput()
    {
        return int.Parse(Console.ReadLine());
    }

    public void EarnPoint(Question question, int userChoice)
    {
        int _correct = question._correctIndex +1;
        userChoice = this.GetUserInput();


        if (_correct == userChoice)
        {
            Console.WriteLine("Correct! Score: +1");
            score++;
            Console.WriteLine($"New Score: {score}");

        }
        else
        {
            Console.WriteLine($"WRONG!! The correct answer is #{_correct}. Better luck next time!");
        }
    }

    public void ShowScore()
    {
        Console.WriteLine($"Your Score is: {score}");
    }


}