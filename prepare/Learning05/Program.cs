using System;
using System.Collections.ObjectModel;

class Program
{
    public static void Main()
    {
        List<Shape> shapes = new List<Shape>();
       
        Square sq = new Square("blue", 8);
        shapes.Add(sq);

        Rectangle rt = new Rectangle("green", 6, 7);
        shapes.Add(rt);

        Circle cl = new Circle("yellow", 5.3);
        shapes.Add(cl);

        foreach (Shape shape in shapes)
        {
            string color = shape.GetColor();
            
            double area = shape.GetArea();

            Console.WriteLine($"The {color} shape has an area of {area}.");
        }
    }

}
