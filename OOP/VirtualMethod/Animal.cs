namespace OOP.VirtualMethod;

public class Animal
{
    public virtual string Name { get; set; } = "Animal";
    public virtual int NumberOfLegs { get; set; } = 4;
}

public class Lion : Animal
{
    public override string Name { get; set; } = "Lion";
}

public class Tiger : Animal
{
    public override string Name { get; set; } = "Tiger";
}

public class Duck: Animal
{
    public override string Name { get; set; } = "Duck";
    public override int NumberOfLegs { get; set; } = 2;
}

public class Spider: Animal
{
    public override string Name { get; set; } = "Spider";
    public override int NumberOfLegs { get; set; } = 8;
}

