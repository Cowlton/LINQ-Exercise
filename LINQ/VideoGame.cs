namespace LINQ;

public class VideoGame : IGame
{
    public string Name { get; set; }
    public string Description { get; set; }
    
    public string Platform { get; set; }

    public bool HasControlerSupport {get; set; }

    public void Display()
    {
        Console.WriteLine($"{Name} is a {Description} played on {Platform}.");
        var controler = HasControlerSupport ? "a Controller" : "a Keyboard";
        Console.WriteLine($"you use {controler}");
    }
}