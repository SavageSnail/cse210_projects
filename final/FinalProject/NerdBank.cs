class NerdBank: QuestionBank
{
    public NerdBank()
    {
    Question question1 = new Question(
            "Who painted the 'Mona Lisa'?",
            new string[] {"1. Michelangelo", "2. Da Vinci", "3. Raphael", "4. Donatello"},
            1
        );
        bank.Add(question1);

        Question question2 = new Question(
            "Which of the Following is NOT a fruit?",
            new string[] {"1. Rhubarb", "2. Tomatoes", "3. Avacados"},
            0
        );
        bank.Add(question2);

        Question question3 = new Question(
            "",
            new string[] {""},
            0
        );
        bank.Add(question3);

        Question question4 = new Question(
            "",
            new string[] {""},
            0
        );
        bank.Add(question4);

        Question question5 = new Question(
            "",
            new string[] {""},
            0
        );
        bank.Add(question5);

        Question question6 = new Question(
            "",
            new string[] {""},
            0
        );
        bank.Add(question6);

        Question question7 = new Question(
            "",
            new string[] {""},
            0
        );
        bank.Add(question7);

        Question question8 = new Question(
            "",
            new string[] {""},
            0
        );
        bank.Add(question8);

        Question question9 = new Question(
            "",
            new string[] {""},
            0
        );
        bank.Add(question9);

        Question question10 = new Question(
            "",
            new string[] {""},
            0
        );
        bank.Add(question10);
    }
}