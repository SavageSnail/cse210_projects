using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

class NormieBank: QuestionBank
{
    //general trivia
    //idea is to compile a question bank when called
    public NormieBank()
    {
        CompileQuestions();
    }
    // I think this is somehow adding null questions??
    public void CompileQuestions()
    {
        // been trying to add these "question" objects a couple different ways now
        AddQ( new Question(
            "Who painted the 'Mona Lisa'?",
            new string[] {"1. Michelangelo", "2. Da Vinci", "3. Raphael", "4. Donatello"},
            1
        ));
        

        Question question2 = new Question(
            "Which of the Following is NOT a fruit?",
            new string[] {"1. Rhubarb", "2. Tomatoes", "3. Avacados"},
            0
        );
        AddQ(question2);

        Question question3 = new Question(
            "Where was the first example of paper money used?",
            new string[] {"1. Turkey", "2. Greece", "3. China", "4. United States"},
            2
        );
        AddQ(question3);

        Question question4 = new Question(
            "Who is generally considered the inventor of the motor car?",
            new string[] {"1. Henry Ford", "2. Karl Benz", "3. Henry M. Lelend", "4. Ferrari"},
            1
        );
        AddQ(question4);

        Question question5 = new Question(
            " Which of the following languages has the longest alphabet?",
            new string[] {"1. Greek", "2. Arabic", "3. German", "4. Russian"},
            3
        );
        AddQ(question5);

        Question question6 = new Question(
            "Where was the earliest documented case of the Spanish flu?",
            new string[] {"1. Spain", "2. Mexico", "3. Venezuela", "4. United States"},
            3
        );
        AddQ(question6);

        Question question7 = new Question(
            "What city hosted the 2002 Olympic games?",
            new string[] {"1. Tokyo", "2. Beijing", "3. Sydney"},
            2
        );
        AddQ(question7);

        Question question8 = new Question(
            "What is the largest US State (by landmass)?",
            new string[] {"1. Alaska", "2. Texas", "3. New York", "4. California"},
            0
        );
        AddQ(question8);

        Question question9 = new Question(
            "What number was the Apollo mission that successfully put a man on the moon for the first time in human history?",
            new string[] {"1. Apollo 11", "2. Apollo 12", "3. Apollo 13", "4. Apollo 14"},
            0
        );
        AddQ(question9);

        Question question10 = new Question(
            "What is the official collective name for a group of unicorns?",
            new string[] {"1. A sparkle", "2. A spell", "3. A Blessing"},
            2
        );
        AddQ(question10);

        Console.WriteLine(question10._questionText);

    }

    // public void WriteOut()
    //     {
    //         foreach (var question in bank)
    //     {
    //         Console.WriteLine(question._questionText);
    //     }
    //     }


    //and the function that throws them all into the bank:
    // public void AddToBank()
    // {
    //     foreach (Question question in )
    //     {
    //         base.AddQuestion(question);
    //     }
    // }
}