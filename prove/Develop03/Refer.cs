using System.Dynamic;
using System.Net.Mime;

public class Refer
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int? _endVerse;


    public Refer()
    {
        GenerateScripture generator = new GenerateScripture();
        Scripture s = generator.ScriptureGenerate();

        _book = s._book;
        _chapter = s._chapter;
        _startVerse = s._verse;
        _endVerse = s._verse2;
    }

    public Refer(Scripture s)
    {
        _book = s._book;
        _chapter = s._chapter;
        _startVerse = s._verse;
        _endVerse = s._verse2;
    }


    public string GetReference()
    {
        if (_endVerse.HasValue)
        {
            return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
        }

        return $"{_book} {_chapter}:{_startVerse}";
    }
}