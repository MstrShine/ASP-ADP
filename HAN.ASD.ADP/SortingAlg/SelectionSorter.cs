using HAN.ASD.ADP.SortingAlg.Interfaces;

namespace HAN.ASD.ADP.SortingAlg
{
    public class SelectionSorter : ISorter
    {
        public void Sort<T>(T[] array) where T : IComparable<T>
        {
            for (int i = 0; i < array.Length; i++)
            {
                int minIndex = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j].CompareTo(array[minIndex]) < 0)
                    {
                        minIndex = j;
                    }
                }

                var temp = array[minIndex];
                array[minIndex] = array[i];
                array[i] = temp;
            }
        }
    }
}
