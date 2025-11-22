
using System.Diagnostics;

public class Fraction
{
    //attributes//
    private int _top;
    private int _bottom;

    //contructors methods//
    public Fraction()
    {
        _top = 1;
        _bottom = 1; 
    }
    public Fraction(int wholeNumber)
    {
        _top = wholeNumber;
        _bottom = 1;   
    }
    public Fraction(int top , int bottom)
    {
        _top = top;
        _bottom = bottom;
    }

    //getters & setter methods//
    public int GetTop()
    {
        return _top;
    }

    public void SetTop(int top)
    {
        _top = top;
    }

    public int GetBottom()
    {
        return _bottom;
    }

    public void SetBottom(int bottom)
    {
        _bottom = bottom;
    }
     private string GetFractionString()
    {
        return _top + "/" + _bottom;
    }

    private double GetDecimalValue()
    {
        return (double)_top / (double)_bottom;
    }

    public void Display()
    {
        Console.WriteLine(GetFractionString());
        Console.WriteLine(GetDecimalValue());
        
    }

}