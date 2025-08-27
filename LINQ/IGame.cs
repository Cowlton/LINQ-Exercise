namespace LINQ;

public interface IGame
{
    public string Name { get; set; }
    public string Description { get; set; }
    
    public void Display();

}