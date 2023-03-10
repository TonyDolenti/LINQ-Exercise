using System.Linq;
namespace LINQ
{
    public class Program
    {
        
        
        
        static void Main(string[] args)
        {
            List<string> videoGames = new List<string>() { "Modern Warfare 19", "Black Ops", "Batman Arkham Knight" };
            videoGames.Add("World At War");
            videoGames.Add("Assassins Creed 3");

            var orderedGames = videoGames.OrderBy(title => title.Length);
            foreach (var games in orderedGames)
            {
                Console.WriteLine(games);
            }
        }
    }
}
