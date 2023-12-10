using System.Collections.Generic;
using System.Diagnostics;
using System.Formats.Asn1;

class TimedQuiz : Quiz
{       //Class for the timed version of the quiz

    QuestionBank _questionbank = new QuestionBank();
    Scoreboard _scoreboard = new Scoreboard();
    Gadgets gadget = new Gadgets();
    private double _duration;
    private double lastFrame;
    private int timedScore = 0;
    private Stopwatch sw = new Stopwatch();

    public TimedQuiz(QuestionBank questionbank, Scoreboard scoreboard) : base(questionbank, scoreboard)
    {
        this._questionbank = questionbank;
        this._scoreboard = scoreboard;
    }

    public override string Intro()
    {
        Console.Clear();
        return "Welcome to the timed game mode! \nAnswer as many questions as you can before time runs out! \nGood Luck!\n";
    }

    private double deltaTime()
    {
        TimeSpan ts = this.sw.Elapsed;
        double firstFrame = ts.TotalMilliseconds;
        double dt = firstFrame - lastFrame;
        this.lastFrame = ts.TotalMilliseconds;
        return dt;
    }

    //Polymorphism!
    public override void AskQuestion()
    {       //for some reason set duration didn't work when outside of this method
        ConsoleKeyInfo key;
        Console.WriteLine(" ");
        Console.WriteLine("\nHow long (in seconds) would you like to set the timer? (Recommended = 30)");
        Console.Write("Duration of quiz: ");
        _duration = int.Parse(Console.ReadLine());
        //gotta reset the timed score if the user goes in and out of option 2 in main
        timedScore = 0;
        gadget.TypeLine("Answer as many questions as you can until there are no more questions or the timer runs out!");
        Console.WriteLine("\nReady... ");
        gadget.CountDown(3);
        Console.WriteLine("");
        //for dramatic effect
        gadget.BlinkWord("Go!!!");
        Console.Clear();

        this.sw.Start();
        double acc = 0.0;

        while (acc <= _duration * 1000)
        {
            acc += this.deltaTime();

            //first thing's first: avoid errors
            if (_questionbank.BankEmpty())
            {
                Console.Write("Oops! I ran out of questions! I guess you're too smart for this... ");
                gadget.Spinner();
                Console.Write("\nExiting Quiz: ");
                gadget.CountDown(4);
                break;
            }

            //very similar to the base
            Question randomQ = _questionbank.GetRandomQuestion();
            Console.WriteLine($"\n{randomQ.GetText()}");
            Console.WriteLine(randomQ.GetOptions());
            int _correct = randomQ.GetIndex() + 1;
            int userGuess = 0;
            //had to move this into its own loop so that the question would display first
            do
            {
                acc += this.deltaTime();
                if (!Console.KeyAvailable)
                {
                    continue;
                }
                key = Console.ReadKey();
                userGuess = int.Parse(key.KeyChar.ToString());
            } while(acc <= _duration * 1000 && userGuess == 0);

            //had to keep track of the score here differently as to not take away from user's time to answer quesitons
            if (_correct == userGuess)
            {
                timedScore++;
            }
            _questionbank.UsedQuestion(randomQ);

        }



        Console.WriteLine("\nTime's up!");
        gadget.Spinner();

        _scoreboard.AddScore(timedScore);

        //take timed score and add it to overall score since they're seperate
        Console.WriteLine(" ");
        Console.WriteLine($"Correct responses: {timedScore} ");
        Console.WriteLine($"New total score: + {timedScore} = {_scoreboard.ShowScore()}");
        gadget.Spinner();
        gadget.Spinner();
    }

}