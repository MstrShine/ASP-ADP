using HAN.ASD.ADP.Datasets;
using HAN.ASD.ADP.Helpers;

namespace HAN.ASD.ADP
{
    public class Program
    {
        static void Main(string[] args)
        {
            var sorting = JsonHelper.LoadJson<SortingDataset>(".\\Datasets\\Raw\\sorting.json");
            var hashing = JsonHelper.LoadJson<HashTabelSleutelWaardesDataset>(".\\Datasets\\Raw\\hashing.json");
            var grafen = JsonHelper.LoadJson<GrafenDataset>(".\\Datasets\\Raw\\grafen.json");
            Console.ReadLine();
        }
    }
}
