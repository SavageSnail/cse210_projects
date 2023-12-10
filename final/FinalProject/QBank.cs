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

    //Used to avoid duplicate questions
    public void UsedQuestion(Question question)
    {
        bank.Remove(question);
    }

    public Question GetRandomQuestion()
    {
        Random random = new Random();
        int pickedInd = random.Next(0, bank.Count());
        Question picked = bank[pickedInd];
        return picked;
    }

    //used in case all the questions have been removed to avoid an error code
    public bool BankEmpty()
    {
        return bank.Count() <= 0;
    }
}