using Hazi_feladat;
using System.Text.Json;

internal class Program
{
    private static void Main(string[] args)
    {
        Database_handler DatabaseHandler = new Database_handler();

        while (true)
        {
            Console.WriteLine("\n--- Film Adatbázis ---");
            Console.WriteLine("1. Film hozzáadása");
            Console.WriteLine("2. Összes film listázása");
            Console.WriteLine("3. LINQ lekérdezések");
            Console.WriteLine("4. Mentés");
            Console.WriteLine("0. Kilépés");
            Console.Write("Választás: ");

            string input = Console.ReadLine() ?? "";
            Console.WriteLine();

            switch (input)
            {
                case "1": DatabaseHandler.AddMovie(); break;
                case "2": DatabaseHandler.ListMovies(); break;
                //case "3": RunLinqQueries(movies); break;
                //case "4": MovieStorage.Save(movies); break;
                case "0": return;
                default: Console.WriteLine("Érvénytelen választás."); break;
            }
        }
    }
}