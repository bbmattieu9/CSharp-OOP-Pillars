

using OOP.Abstraction;
using OOP.MethodOverloading;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("==== C# OOP Program ===");

        // var dogOne = new Dog("Lucky", "german shepherd", 40);
        // Console.WriteLine(dogOne.Describe());
        
        // var dogTwo = new Dog("Tina", 25);
        // Console.WriteLine(dogTwo.Describe());

        // var firstRectangle = new Rectangle(5.0, 10.0);
        // var areaOfRectangle = firstRectangle.CalculateArea();
        //
        // Console.WriteLine($"Height of Rectangle: {firstRectangle.Height}");
        // Console.WriteLine($"Width of Rectangle: {firstRectangle.Width}");
        //
        // Console.WriteLine($"Area of Rectangle= {areaOfRectangle}");

        var rect = new Rectangle(8, 4);
        Console.WriteLine(rect);
        Console.WriteLine(Rectangle.CountOfInstances);

        // var triAngle = new Triangle(10, 7);
        // triAngle.AsString();
        // Console.WriteLine(triAngle.CalculateArea());

    }
}