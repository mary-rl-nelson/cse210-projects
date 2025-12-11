using System;

class Program
{
    static void Main(string[] args)
    {
        Square sShape = new Square();
        sShape.SetColor("blue");
        sShape.SetSide(4);

        Rectangle rShape = new Rectangle();
        rShape.SetColor("red");
        rShape.SetLength(6);
        rShape.SetWidth(2);

        Circle cShape = new Circle();
        cShape.SetColor("yellow");
        cShape.SetRadius(2);

        List<Shape> shapes = new List<Shape>();
        shapes.Add(cShape);
        shapes.Add(rShape);
        shapes.Add(sShape);

        foreach (Shape s in shapes)
        {
            double area = s.GetArea();
        }

        sShape.DisplayShapeInformation();
        rShape.DisplayShapeInformation();
        cShape.DisplayShapeInformation();

    }
}