Hello!

Welcome to the Mandatory Fun trivia game!

1. How to play
    -the main menu (I hope) is pretty straight forward. Select an option and play!
    -1 = normal mode; no timer, just asks questions from 2 different categories.
    -2 = now you answer on a timer, you won't be able to take a break between each quesiton because you need to rush!
    -3 = View your score. It's saved between the 2 game modes and genres! 
    -4 = Refill the banks. When you answer a question, it's removed from the bank. option 4 lets you refill the banks with all the questions without having to quit 
        -You can also reset your score if you want to!

2. How I met requirements:
    -I made 8 different classes
    -Each class is responsible for its own thing and doesn't overlap with another class (abstraction).
    -all attributes are private or protected, most methods are public (encapsulation).
    -Nerdbank and Normiebank both are Questionbanks, but each one sets up the bank differently (inheritance)
    -TimedQuiz overrides stuff the base Quiz sets up, namely AskQuestion() (Polymorphism)
        -I kept TimedQuiz as a quiz instead of it's own thing so that it can keep track of score and questionbanks with the regular quiz

3. Warnings
    - Pretty much just please don't use inputs that aren't requested (like a letter on the main menu). This will crash the program
    - the only time you won't use just a 1 digit number is in option 1, when it asks if you'd like to continue
    - besides that I think it's been running pretty smoothly!


-----THANKS FOR PLAYING-----