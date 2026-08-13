namespace OOP.SingleRespPrinciple;

public class StringTextualRepository
{
    private static readonly string Separator = Environment.NewLine;
    
    public List<string> Read(string filePath)
    {
        var fileContents = File.ReadAllText(filePath);
        return fileContents.Split(Separator).ToList();
       
    }
    
    public void Write(string filePath, List<string> contents) => 
        File.WriteAllText(filePath, string.Join(Separator, contents));
}