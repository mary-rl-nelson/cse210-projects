using System;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        Fraction fraction = new(1);
        fraction.Display();

        Fraction fraction1 = new (5);
        fraction1.Display();

        Fraction fraction2 = new(3, 4);
        fraction2.Display();

        Fraction fraction3 = new(1, 3);
        fraction3.Display();

        Fraction fraction4 = new(1);
        fraction4.Display();
        fraction4.SetBottom(2);
        fraction4.Display();
    }
}