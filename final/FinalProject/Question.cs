using System.Diagnostics.Contracts;
using System.Dynamic;
using System.Threading.Tasks.Dataflow;

class Question
{
    // THE BASE
    // this class is intended to be an object
    //the {get/set} stuff is new to me, but I kept getting errors that the values were "never assigned to, and will always be null"
    private string _questionText {get; set;}
    private string[] _options {get; set;}
    private int _correctIndex {get; set;}

    public Question(string text, string[] options, int correct)
    {
        _questionText = text;
        _options = options;
        _correctIndex = correct;
    }

    public string GetText()
    {
        return this._questionText;
    }

    public string GetOptions()
    {
        return string.Join(" \n", _options);
    }

    public int GetIndex()
    {
        return _correctIndex;
    }
}