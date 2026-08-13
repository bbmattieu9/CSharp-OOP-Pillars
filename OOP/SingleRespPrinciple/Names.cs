namespace OOP.SingleRespPrinciple;

public class Names
{
    public List<string> All { get; } = new List<string>();
    private readonly NamesValidator _namesValidator = new NamesValidator();

    public void AddNames(List<string> stringsFromFile)
    {
        foreach (var name in stringsFromFile)
        {
            AddName(name);
        }
    }
    
    public void AddName(string name)
    {
        // var validator = new NamesValidator();
        // then do
        // validator.IsValidName(name)
        // or use short form below
        // new NamesValidator().IsValidName(name)
        // but - it means a new Object of NamesValidator will be created
        // each time the AddName method is called
        
        // We can create such an Object once and simply store it as
        // a private filed in the names class
        if(_namesValidator.IsValid(name))
        {
            All.Add(name);
        }
    }
    
}