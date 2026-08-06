namespace OOP.Abstraction;

public class Triangle(int baseNumber, int height)
{
    public int Base { get; set; } = baseNumber;
    public int Height { get; set; } =  height;

    public int CalculateArea()
    {
        return (Base * Height) / 2;
    }

    public string AsString()
    {
        return $"Base is {Base}, Height is {Height}";
    }
}