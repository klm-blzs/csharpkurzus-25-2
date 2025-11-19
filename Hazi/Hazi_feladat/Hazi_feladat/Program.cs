using Hazi_feladat;
using System.Text.Json;

try
{
    string json = File.ReadAllText("movies.json");

    List<Movie>? Movies = JsonSerializer.Deserialize<List<Movie>>(json);

    if (Movies is not null)
    {
        Console.WriteLine("Film adatbázis betöltve:");
        Console.WriteLine($"Összes film: {Movies.Count}");
    }
    else
    {
        Console.WriteLine("A JSON fájl üres vagy hibás formátumú.");
    }

   

}
catch (IOException ex)
{
    Console.WriteLine("Hiba történt a beolvasás közben:");
    Console.WriteLine(ex.Message);
}
