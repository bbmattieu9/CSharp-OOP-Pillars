

using OOP.Abstraction;
using OOP.MethodOverloading;
using OOP.SingleRespPrinciple;

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

        // var rect = new Rectangle(8, 4);
        // Console.WriteLine(rect);
        // Console.WriteLine(Rectangle.CountOfInstances);

        // var triAngle = new Triangle(10, 7);
        // triAngle.AsString();
        // Console.WriteLine(triAngle.CalculateArea());


        Console.WriteLine("==== Single Responsibility Principle ===");
        
        var names = new Names();
        var path = new NamesFilePathBuilder().BuildFilePath();
        var stringsTextualRepository = new StringTextualRepository();
        if (File.Exists(path))
        {
            Console.WriteLine("Names files already exists. Loading names...");
            var stringsFromFile = stringsTextualRepository.Read(path);
            names.AddNames(stringsFromFile);
        }
        else
        {
            Console.WriteLine("Names files do not exist. Creating names...");
            // Create an imaginary list of names
            names.AddName("Brandy");
            names.AddName("not a valid name");
            names.AddName("Jackson");
            names.AddName("123 definitely not a valid name");
            
            Console.WriteLine("Names saved and file successfully loaded.");
            stringsTextualRepository.Write(path, names.All);
        }
        
        Console.WriteLine(new NamesFormatter().Format((names.All)));
    }
}