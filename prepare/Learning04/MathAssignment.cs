using System.Diagnostics.Contracts;
public class Math: Assignment 
{
    private string _textbookSec = "";
    private string _problems;

    public Math(string student, string topic, string textbookSec, string problems) : base(student, topic)
    {
        _textbookSec = textbookSec;

        _problems = problems;
    }

    public string GetHWList()
    {
        return $"Section: {_textbookSec} Problems: {_problems}";
    }
}