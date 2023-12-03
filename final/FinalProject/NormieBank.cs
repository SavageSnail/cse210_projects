using System.ComponentModel;

class NormieBank: QuestionBank
{
    private List<Question> _normies = new List<Question>();

    //here's the function that gets all the questions written out
    public void MakeBank()
    {
        Question question1 = new Question(
            "Who painted the 'Mona Lisa'?",
            new string[] {"1. Michelangelo", "2. Da Vinci", "3. Raphael", "4. Donatello"},
            1
        );
        base.AddQuestion(question1);

        Question question2 = new Question(
            "Which of the Following is NOT a fruit?",
            new string[] {"1. Rhubarb", "2. Tomatoes", "3. Avacados"},
            0
        );
        base.AddQuestion(question2);

        Question question3 = new Question(
            "",
            new string[] {""},
            0
        );
        base.AddQuestion(question3);

        Question question4 = new Question(
            "",
            new string[] {""},
            0
        );
        base.AddQuestion(question4);

        Question question5 = new Question(
            "",
            new string[] {""},
            0
        );
        base.AddQuestion(question5);

        Question question6 = new Question(
            "",
            new string[] {""},
            0
        );
        base.AddQuestion(question6);

        Question question7 = new Question(
            "",
            new string[] {""},
            0
        );
        base.AddQuestion(question7);

        Question question8 = new Question(
            "",
            new string[] {""},
            0
        );
        base.AddQuestion(question8);

        Question question9 = new Question(
            "",
            new string[] {""},
            0
        );
        base.AddQuestion(question9);

        Question question10 = new Question(
            "",
            new string[] {""},
            0
        );
        base.AddQuestion(question10);
    }

    //and the function that throws them all into the bank:
    public void AddToBank()
    {
        foreach (Question question in _normies)
        {
            base.AddQuestion(question);
        }
    }
}