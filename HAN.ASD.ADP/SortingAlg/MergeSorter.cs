using HAN.ASD.ADP.SortingAlg.Interfaces;

namespace HAN.ASD.ADP.SortingAlg
{
    public class MergeSorter : ISorter
    {
        public void Sort<T>(T[] array) where T : IComparable<T>
        {
            var buffer = new T[array.Length];
            Split(array, 0, array.Length - 1, buffer);
        }

        private static void Split<T>(T[] array, int left, int right, T[] buffer) where T : IComparable<T>
        {
            if (left < right)
            {
                int center = (left + right) / 2;
                Split(array, left, center, buffer);
                Split(array, center + 1, right, buffer);
                Merge(array, left, center, right, buffer);
            }
        }

        public static void Merge<T>(T[] array, int left, int middle, int right, T[] buffer) where T : IComparable<T>
        {
            int i = left;
            int j = middle + 1;
            int k = left;

            Array.Copy(array, left, buffer, left, right - left + 1);

            while (i <= middle && j <= right)
            {
                if (buffer[i].CompareTo(buffer[j]) <= 0)
                {
                    array[k] = buffer[i];
                    i++;
                }
                else
                {
                    array[k] = buffer[j];
                    j++;
                }
                k++;
            }

            while (i <= middle)
            {
                array[k] = buffer[i];
                i++;
                k++;
            }

            while (j <= right)
            {
                array[k] = buffer[j];
                j++;
                k++;
            }
        }
    }
}
