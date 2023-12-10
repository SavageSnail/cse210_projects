using System;
using System.Collections.Generic;

class Quiz 
{
    // this class should be running the game (mostly) i.e. meant to make the main program look less clutered
    Scoreboard _scoreboard = new Scoreboard();
    QuestionBank _questionBank = new QuestionBank();
    Gadgets gadget = new Gadgets();

    public Quiz(QuestionBank questionBank, Scoreboard scoreboard)
    {
        this._questionBank = questionBank;
        this._scoreboard = scoreboard;
    }

    public virtual string Intro()
    {
        Console.Clear();
        return "Welcome to the classic mode quiz! \n In this game mode, you will be asked a series of multiple choice questions. You get a point for each question you get correct! \n Good Luck!\n"; 
    }

    //Where the magic happens
    public virtual void AskQuestion()
    {
        string keepPlay;
        do {
        Console.Clear();
        //start with avoiding an error
        if (_questionBank.BankEmpty())
        {
            Console.Write("Oops! I ran out of questions! I guess you're too smart for this... ");
            gadget.Spinner();
            Console.WriteLine("Returning to main menu: ");
            gadget.CountDown(4);
            break;
        }

        //select random question object, write question, write answers, check for right or wrong
        Question randomQ = _questionBank.GetRandomQuestion();
        Console.WriteLine(randomQ.GetText());
        Console.WriteLine(randomQ.GetOptions());
        _scoreboard.EarnPoint(randomQ, _scoreboard.GetUserInput());
        _questionBank.UsedQuestion(randomQ);

        //a way to break the loop in case the user wants to quit after each question
        Console.WriteLine("");
        Console.WriteLine("Would you like to keep playing this mode? (Yes/No): ");
        keepPlay = Console.ReadLine();

        } while (keepPlay.ToLower() == "yes");
    }

    public string ShowScore()
    {
        return _scoreboard.ShowScore();
    }

}