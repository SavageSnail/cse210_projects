using System.Runtime.CompilerServices;
using System.Security.Cryptography;

public class Scripture 
{

    private List<Word> _words = new List<Word>();

    //private Reference reference;

    private bool _isHidden;


    public Scripture(string wholeScrip)
    {
        string[] oneWord = wholeScrip.Split(" ");


        foreach (var word in oneWord)
        {
            _words.Add(new Word(word));
        }
    }
    

    public void HideWords()
    {
        //random choice
        Random chooseWord = new Random();
       

        List<Word> nonHidden = new List<Word>();

        //build list of non-hidden word objects
        foreach (Word word in _words)
        {
            if (word.IsHidden())
            {

            }
            else
            {
                nonHidden.Add(word);
            }
        }

        int wordsToPick = 3;
        //second list to pick 3 non-hidden words
        List<Word> choiceWords = new List<Word>();

        if (nonHidden.Count >= wordsToPick)
        {
            while (choiceWords.Count < wordsToPick)
            {
                int chosen = chooseWord.Next(0,nonHidden.Count);

                //don't double pick
                if (!choiceWords.Contains(nonHidden[chosen]))
                {
                    choiceWords.Add(nonHidden[chosen]);
                }
            }
        }

        //hide em
        foreach (Word word1 in choiceWords)
        {
            word1.Hide();
        }

        //nonHidden.ForEach(p=>Console.Write(p.GetRenderedText()));

    }

    public void GetRenderedText()
    {
        List<Word> wholeThing = new List<Word>();

        foreach (Word word in _words)
        {
            wholeThing.Add(word);
        }

        _words.ForEach(p=>Console.Write($" {p.GetRenderedText()}"));
    }

    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (word.IsHidden())
            {
               return _isHidden = true;
            }

            else 
            {
               return _isHidden = false;
            }
        }
        return _isHidden;
        //if all things are _, return true
        //else return false
    }
}