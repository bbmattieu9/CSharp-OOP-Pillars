namespace OOP.Abstraction;

public class Rectangle
{
    public  int Height { get; set; }
    public int Width { get; set; }
    
    public Rectangle(int height, int width)
        {
        Height = GetLengthOrDefault(height, nameof(Height));
        Width = GetLengthOrDefault(width, nameof(Width));
        }

    private int GetLengthOrDefault(int length, string name)
    {
        const int defaultValueIfNonPositive = 1;
        if (length <= 0)
        {
            Console.WriteLine($"{name} must be  a postive number.");
            return  defaultValueIfNonPositive;
        }

        return length;
    }
    
    public int CalculateArea() => Height * Width;
  

    public int CalculateCircumference() => (Height + Width) * 2;
}