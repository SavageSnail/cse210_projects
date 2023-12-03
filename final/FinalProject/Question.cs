class Question
{
    private string _questionText;
    private string[] _options;
    //wanted to make it private, but the scoreboard check would have been much more complicated
    public int _correctIndex;

    public Question(string text, string[] options, int correct)
    {
        text = _questionText;
        options = _options;
        correct = _correctIndex;
    }
}