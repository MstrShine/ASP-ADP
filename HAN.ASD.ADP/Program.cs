using HAN.ASD.ADP.Datasets;
using HAN.ASD.ADP.Helpers;

namespace HAN.ASD.ADP
{
    public class Program
    {
        static void Main(string[] args)
        {
            var sorting = JsonHelper.LoadJson<Sorting>(".\\Datasets\\Raw\\sorting.json");
            var hashing = JsonHelper.LoadJson<HashTabelSleutelWaardes>(".\\Datasets\\Raw\\hashing.json");
            var grafen = JsonHelper.LoadJson<Grafen>(".\\Datasets\\Raw\\grafen.json");
            Console.ReadLine();
        }
    }
}
