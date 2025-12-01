public class Refer
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int? _endVerse;

    public Refer(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = verse;
        _endVerse = null;
    }

    public Refer(string book, int chapter, int verse, int verse2)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = verse;
        _endVerse = verse2;
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
