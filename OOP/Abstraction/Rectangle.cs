namespace OOP.Abstraction;

public class Rectangle
{
    public double Height { get; set; }
    public double Width { get; set; }
    
    public Rectangle(double height, double width)
        {
        Height = height;
        Width = width;
        }
    
    public double CalculateArea() => Height * Width;
  

    public double CalculateCircumference() => (Height + Width) * 2;
}