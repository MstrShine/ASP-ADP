using HAN.ASD.ADP.Datasets;
using HAN.ASD.ADP.Helpers;
using HAN.ASD.ADP.SortingAlg;

namespace HAN.ASD.ADP
{
    public class Program
    {
        static void Main(string[] args)
        {
            var test = new int[] { 6, 5, 3, 2, 1, 9, 10, 11, 24, 45, 30, 50, 35, 16, 60, 88, 70, 55 };
            QuickSorter<int>.QuickSort(test);

            var sorting = JsonHelper.LoadJson<Sorting>(".\\Datasets\\Raw\\sorting.json");
            var hashing = JsonHelper.LoadJson<HashTabelSleutelWaardes>(".\\Datasets\\Raw\\hashing.json");
            var grafen = JsonHelper.LoadJson<Grafen>(".\\Datasets\\Raw\\grafen.json");
            Console.ReadLine();
        }
    }
}
