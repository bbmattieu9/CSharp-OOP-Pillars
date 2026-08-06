

using OOP.Abstraction;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("==== C# OOP Program ===");
        
        // var firstRectangle = new Rectangle(5.0, 10.0);
        // var areaOfRectangle = firstRectangle.CalculateArea();
        //
        // Console.WriteLine($"Height of Rectangle: {firstRectangle.Height}");
        // Console.WriteLine($"Width of Rectangle: {firstRectangle.Width}");
        //
        // Console.WriteLine($"Area of Rectangle= {areaOfRectangle}");

        var triAngle = new Triangle(10, 7);
        triAngle.AsString();
        Console.WriteLine(triAngle.CalculateArea());

    }
}