using System;
using System.Drawing;
using System.Globalization;

public abstract class Shape
{
    private string _color;
    private string _name;

    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public string GetColor()
    {
        return _color;
    }

    public void SetColor(string color)
    {
        _color = color;
    }

    public abstract double GetArea();


    public void DisplayShapeInformation()
    {
        Console.Write($"Shape: {GetName()}, Color: {GetColor()}, Area: {GetArea()}\n");
    }
}