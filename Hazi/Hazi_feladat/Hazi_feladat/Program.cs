using Hazi_feladat;
using System.Text.Json;

internal class Program
{
    private static void Main(string[] args)
    {
        Database_handler DatabaseHandler = new Database_handler();

        foreach (var movie in DatabaseHandler.getMovies())
        {
            Console.WriteLine(movie.Title);

        }
    }
}