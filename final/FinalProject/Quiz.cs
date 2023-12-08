using System;
using System.Collections.Generic;

class Quiz 
{
    Scoreboard _scoreboard = new Scoreboard();
    QuestionBank _questionBank = new QuestionBank();
    NormieBank _normieBank = new NormieBank();
    NerdBank _nerdBank = new NerdBank();
    Gadgets gadget = new Gadgets();

    public Quiz(QuestionBank questionBank, Scoreboard scoreboard)
    {
        this._questionBank = questionBank;
        this._scoreboard = scoreboard;
    }

    public string Intro()
    {
        Console.Clear();
        return "Welcome to the classic mode quiz! \n In this game mode, you will be asked a series of multiple choice questions. You get a point for each question you get correct! \n Good Luck!"; 
    }

    public void AskQuestion()
    {
        string keepPlay;
        do {
        Console.Clear();
        Question randomQ = _questionBank.GetRandomQuestion();
        Console.WriteLine(randomQ._questionText);
        //Console.WriteLine(randomQ.GetOptions());
        //_scoreboard.GetUserInput();
        _scoreboard.EarnPoint(randomQ, _scoreboard.GetUserInput());
        _questionBank.UsedQuestion(randomQ);

        if (_questionBank.BankEmpty())
        {
            Console.Write("Oops! I ran out of questions! I guess you're too smart for this... ");
            gadget.Spinner();
            Console.WriteLine("Returning to main menu: ");
            gadget.CountDown(4);
            break;
        }

        Console.WriteLine("");
        Console.WriteLine("Would you like to keep playing this mode? (Yes/No): ");
        keepPlay = Console.ReadLine();

        } while (keepPlay.ToLower() == "yes");
    }

    public void ShowScore()
    {
        _scoreboard.ShowScore();
    }

}