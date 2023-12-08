class QuestionBank 
{
    protected List<Question> bank = new List<Question>();

    //doing this to get access to the bank
    public QuestionBank()
    {
        bank  = new List<Question>();
    }

    public void AddQ(Question question)
    {
        bank.Add(question);
    }

    public void UsedQuestion(Question question)
    {
        bank.Remove(question);
    }

    public Question GetRandomQuestion()
    {
        Random random = new Random();
        int pickedInd = random.Next(0, bank.Count());
        Console.WriteLine(bank.Count());
        Question picked = bank[pickedInd];
        Console.WriteLine(picked._questionText);
        return picked;
    }

    public bool BankEmpty()
    {
        return bank.Count() <= 0;
    }
}