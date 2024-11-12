using HAN.ASD.ADP.Datasets;
using System.Text.Json;

namespace HAN.ASD.ADP
{
    public class Program
    {
        static void Main(string[] args)
        {
            var sorting = LoadJson<Sorting>(".\\Datasets\\Raw\\sorting.json");
            var hashing = LoadJson<HashTabelSleutelWaardes>(".\\Datasets\\Raw\\hashing.json");
            var grafen = LoadJson<Grafen>(".\\Datasets\\Raw\\grafen.json");
            Console.ReadLine();
        }

        public static T? LoadJson<T>(string path) where T : class
        {
            T? items = null;
            using (var reader = new StreamReader(path))
            {
                var json = reader.ReadToEnd();
                if (json != null)
                {
                    items = JsonSerializer.Deserialize<T?>(json);
                }
            }

            return items;
        }
    }
}
