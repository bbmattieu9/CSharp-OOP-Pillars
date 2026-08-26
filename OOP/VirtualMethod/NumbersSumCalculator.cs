namespace OOP.VirtualMethod;

public class NumbersSumCalculator
{
    public int Calculate(List<int> numbers)
    {
        int sum = 0;
        foreach (var number in numbers)
        {
            if (ShallBeAdded(number))
            {
                sum += number;
            }
        }
        return sum;
    }

    protected virtual bool ShallBeAdded(int numbers)
    {
        return true;
    }
}


public class PositiveNumbersSumCalculator
: NumbersSumCalculator
{
    protected override bool ShallBeAdded(int numbers)
    {
        return numbers > 0;
    }
}