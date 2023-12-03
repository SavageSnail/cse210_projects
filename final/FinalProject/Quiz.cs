class Quiz 
{
    Scoreboard _scoreboard = new Scoreboard();
    QuestionBank _questionBank = new QuestionBank();
    Gadgets gadget = new Gadgets();



    public void MakeDaBank()
    {
        Console.WriteLine("What category would you like to play? ");
        Console.WriteLine("1. General   // 2. Halo");
        Console.Write("or 3 for both: ");
        int userChoice = int.Parse(Console.ReadLine());

        if (userChoice == 1)
        {
            Console.WriteLine("Normie stuff it is!");
            NormieBank normieBank = new NormieBank();
            //this part no work. Why?
            normieBank.MakeBank();
            Console.Write("Getting the quiz ready... ");
            gadget.Spinner();
        }

        else if (userChoice == 2)
        {
            Console.WriteLine("Halo stuff it is!");
            Console.Write("Getting the quiz ready... ");
            gadget.Spinner();
        }

        else if (userChoice == 3)
        {
            Console.WriteLine("Alright, just a bit of both!");
            Console.Write("Getting the quiz ready... ");
            gadget.Spinner();
        }

        else
        {
            Console.Write("Oops, that wasn't an option!");
            gadget.Spinner();
            Console.WriteLine(" ");
        }
    }

    public void AskQuestion()
    {
        string keepPlay;
        do {
        // Question randomQ = _questionBank.GetRandomQuestion();
        // Console.WriteLine(randomQ.GetText());
        // Console.WriteLine(randomQ.GetOptions());
        // //_scoreboard.GetUserInput();
        // _scoreboard.EarnPoint(randomQ, _scoreboard.GetUserInput());

        if (_questionBank.BankEmpty())
        {
            Console.Write("Oops! I ran out of questions! I guess you're too smart for this... ");
            gadget.Spinner();
            Console.WriteLine("Returning to main menu: ");
            gadget.CountDown(4);
            break;
        }

        Console.WriteLine("Would you like to keep playing this mode? (Yes/No): ");
        keepPlay = Console.ReadLine();

        if (keepPlay.ToLower() == "no")
        {
            _questionBank.ClearBank();
        }

        } while (keepPlay.ToLower() == "yes");
    }

    public void ShowScore()
    {
        _scoreboard.ShowScore();
    }

}