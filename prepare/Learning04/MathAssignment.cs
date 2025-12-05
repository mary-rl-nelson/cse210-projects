using System;

public class MathAssignment : Assignment
{
    private string _textbookSection = "";
    private string _problems = "";

    public MathAssignment() : base()
    {
        _textbookSection = "hmmm";
        _problems = "uhoh";
    }

    public MathAssignment(string name, string topic, string textbookSection, string problems) : base(name,topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public string GetSection()
    {
        return _textbookSection;
    }

    public void SetSection(string textbookSection)
    {
        _textbookSection = textbookSection;
    }

    public string GetProblems()
    {
        return _problems;
    }

    public void SetProblems(string problems)
    {
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"{GetAssignmentInfo()}\nSection: {_textbookSection}, Problems: {_problems}";
    }






}
