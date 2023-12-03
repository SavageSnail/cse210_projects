using System.Threading.Tasks.Dataflow;

class Question
{
    private string _questionText;
    private string[] _options;
    //wanted to make it private, but I couldn't get scoreboard check to work
    private int _correctIndex;

    public Question(string text, string[] options, int correct)
    {
        text = _questionText;
        options = _options;
        correct = _correctIndex;
    }

    public string GetText()
    {
        return _questionText;
    }

    public string GetOptions()
    {
        return string.Join(" ", _options);
    }

    public int GetIndex()
    {
        return _correctIndex;
    }
}