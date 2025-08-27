using System.Linq;
namespace LINQ
{
    public class Program
    {
        static void Main(string[] args)
        {
            var bGame1 = new BordGame() { Name = "Chess", HasPieces = true, Description = "A complex strategy game", HasCards = false};
            var bGame2 = new BordGame(){Name = "Uno", HasPieces = false, HasCards = true, Description = "a luck based matching game"};
            var vGame1 = new VideoGame() { Name = "Puzletun", Description = "A throw-back timing driven puzzle game.", HasControlerSupport = true, Platform = "PC and Console"};
            var vGame2 = new VideoGame(){Name = "Un-friendly fire", Description = "A chaotic PVP party game.", HasControlerSupport = true, Platform = "PC and Console"};
            
            List<IGame> gameList = new List<IGame>();
            
            gameList.Add(bGame1);
            gameList.Add(bGame2);
            gameList.Add(vGame1);
            gameList.Add(vGame2);
            
            var gameSort = gameList.OrderByDescending(n => n.Name.Length).ToList();

            foreach (var game in gameSort)
            {
                game.Display();
                Console.WriteLine();
            }
        }
    }
}
