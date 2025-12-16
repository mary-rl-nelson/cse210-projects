using System;

public class Videos
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comments> _comments;

    public Videos(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comments>();
    }

    public string GetTitle()
    {
        return _title;
    }

    public string GetAuthor()
    {
        return _author;
    }

    public int GetLength()
    {
        return _length;
    }

    public int GetCount()
    {
        return _comments.Count(); 
    }

    public List<Comments> GetComments()
    {
        return _comments;
    }


}