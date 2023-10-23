using System.ComponentModel;
using System.Diagnostics.Contracts;

public class Word 
{
    private string _text;
    // text should == each word in scripture
    private bool _hidden;


    public Word(string letter)
    {
        _text = letter;
        _hidden = false;
    }
    public void Hide()
    {
        _text = _text.Replace(_text, "____");
        _hidden = true;
    }

    public bool IsHidden()
        {
        if (_hidden){
            return true;
        }
        else {
            return false;
        }
    }

    public string GetRenderedText()
    {
        return _text;
    }

        
        
}




// This will start by displaying "AAA" and waiting for the user to press the enter key
//Console.WriteLine("AAA");
//Console.ReadLine();

// This will clear the console
//Console.Clear();

// This will show "BBB" in the console where "AAA" used to be
//Console.WriteLine("BBB");

