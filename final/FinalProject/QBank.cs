class QuestionBank 
{
    protected List<Question> bank = new List<Question>();

    public void AddQuestion(Question question)
    {
        bank.Add(question);
    }

    public void UsedQuestion()
    {

    }

    public void ClearBank()
    {
        foreach (Question question in bank)
        {
            bank.Remove(question);
        }
    }

    public Question GetRandomQuestion()
    {
        Random random = new Random();
        int pickedQ = random.Next(0, bank.Count());
        Question picked = bank[pickedQ];
        return picked;
    }

    public bool BankEmpty()
    {
        return bank.Count() <= 0;
    }
}