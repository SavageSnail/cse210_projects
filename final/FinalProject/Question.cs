using System.Diagnostics.Contracts;
using System.Threading.Tasks.Dataflow;

class Question
{
    // THE BASE
    // this class is intended to be an object
    public string _questionText;
    public string[] _options;
    //wanted to make it private, but I couldn't get scoreboard check to work
    public int _correctIndex;

    public Question(string text, string[] options, int correct)
    {
        text = _questionText;
        options = _options;
        correct = _correctIndex;
    }

    // public string GetText()
    // {
    //     return this._questionText;
    // }

    // public string GetOptions()
    // {
    //     return string.Join(" \n", _options);
    // }

    // public int GetIndex()
    // {
    //     return _correctIndex;
    // }
}