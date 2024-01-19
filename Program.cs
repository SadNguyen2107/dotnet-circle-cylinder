using System;

public class TestShapes
{
    public static void Main(string[] args)
    {
        Circle circle = new Circle(5.0, "Red");
        Console.WriteLine(circle.ToString());
        Console.WriteLine($"Area: {circle.GetArea()}");

        Cylinder cylinder = new Cylinder(5.0, "Blue", 10.0);
        Console.WriteLine(cylinder.ToString());
        Console.WriteLine($"Volume: {cylinder.GetVolume()}");
    }
}
