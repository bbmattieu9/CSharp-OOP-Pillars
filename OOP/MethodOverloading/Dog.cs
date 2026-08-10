namespace OOP.MethodOverloading;

public class Dog
{
  public string Name { get; private set; }
  public string Breed { get; private set; }
  public int Weight { get; private set; }

  public Dog(string name, string breed, int weight)
  {
    Name = name;
    Breed = breed;
    Weight = weight;
  }

  public Dog(string name, int weight)
  {
    Name = name;
    Weight = weight;
    Breed = "mixed-breed";
  }

  public string Describe()
  {
    string dogDescription = "";
    if (Weight < 5)
      dogDescription = "tiny";
    else if (Weight < 30)
      dogDescription = "medium";
    else
      dogDescription = "large";
    
    return $"This dog is named {Name}, it's a {Breed}, and it weighs {Weight} kilograms, so it's a {dogDescription} dog.";
  }
  
}
