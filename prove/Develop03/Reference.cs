using System.Threading.Tasks.Dataflow;

public class Reference
{
    private string _book;
    private string _chapter;
    private string _verse;

    public Reference(string book, string chapter, string verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
    }

    public Reference(string book, string chapter, string verse, string endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = $"{verse}-{endVerse}";
    }

    public string GetRenderedText()
    {
        return $"{_book} {_chapter}:{_verse}- ";
    }

}