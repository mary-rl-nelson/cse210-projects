using System.Dynamic;
using System.Net.Mime;

public class Refer
{
    private string _book;
    private string _chapter;
    private int _startVerse;
    private int? _endVerse;


    Refer()
    {
        //Generate scripture
    }

    public Refer(string book, string chapter, int verse, string content)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = Verse1;
        _endVerse = null;
    }

    public Refer(string book, string chapter, int Verse1, int Verse2, string content)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = Verse1;
        _endVerse = Verse2;

    }

    public string GetReference()
    {
        return _book + " " +_chapter+":"+_startVerse;
    }
     public string GetReferenceMultVerse()
    {
        return _book + " " +_chapter+":"+_startVerse+"-"+_endVerse;
    }

}