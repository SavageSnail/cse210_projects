class QuestionBank 
{
    protected List<Question> bank = new List<Question>();

    public void AddQuestion()
    {

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

    public void GetRandomQuestion()
    {
        Random random = new Random();
    }
}