namespace LINQ;

public class BordGame : IGame
{
    public string Name { get; set; }
    public string Description { get; set; }
    public bool HasCards { get; set; }
    public bool HasPieces { get; set; }
    public void Display()
    {
        var useCards = HasCards ? "Use" : "Do not use";
        var usePieces = HasPieces ? HasCards ? "and also use" : "instead you use" : HasCards ? "instead of" : "nor";
        Console.WriteLine($"{Name} is {Description}. You {useCards} cards, {usePieces} pieces.");
    }
}