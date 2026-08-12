namespace OOP.Abstraction;

public class Rectangle
{
    public static int CountOfInstances { get; private set; }
    private static DateTime _firstUsed;
    
    // initialize 
    // private static DateTime _firstUsed = DateTime.Now;

    // using static constructor
    static Rectangle()
    {
        _firstUsed = DateTime.Now;
    }
    
    // public  readonly int Height;
	private int _height;
    private int _width;
    
    public Rectangle(int height, int width)
        {
        _height = GetLengthOrDefault(height, nameof(_height));
        _width = GetLengthOrDefault(width, nameof(_width));
        ++CountOfInstances;
        }

	public int GetHeight() => _height;

	public void SetHeight(int value) 
	{
		if (value > 0)
		{
            _height = value;
        }
}

    private int GetLengthOrDefault(int length, string name)
    {
        const int defaultValueIfNonPositive = 1;
        if (length <= 0)
        {
            Console.WriteLine($"{name} must be  a positive number.");
            return  defaultValueIfNonPositive;
        }

        return length;
    }
    
    public int CalculateArea() => _height * _width;
  

    public int CalculateCircumference() => (_height + _width) * 2;
}