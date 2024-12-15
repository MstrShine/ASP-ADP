using HAN.ASD.ADP.SortingAlg.Interfaces;

namespace HAN.ASD.ADP.SortingAlg
{
    public class MergeSorter : ISorter
    {
        public void Sort<T>(T[] array) where T : IComparable<T>
        {
            Split(array, 0, array.Length - 1);
        }

        private static void Split<T>(T[] array, int left, int right) where T : IComparable<T>
        {
            if (left < right)
            {
                int center = (left + right) / 2;
                Split(array, left, center);
                Split(array, center + 1, right);
                Merge(array, left, center, right);
            }
        }

        public static void Merge<T>(T[] array, int left, int middle, int right) where T : IComparable<T>
        {
            int l = middle - left + 1;
            int r = right - middle;
            var tempLeft = new T[l];
            var tempRight = new T[r];
            Array.Copy(array, left, tempLeft, 0, l);
            Array.Copy(array, middle + 1, tempRight, 0, r);

            int i = 0;
            int j = 0;
            int k = left;

            while (i < l && j < r)
            {
                if (tempLeft[i].CompareTo(tempRight[j]) <= 0)
                {
                    array[k] = tempLeft[i];
                    i++;
                }
                else
                {
                    array[k] = tempRight[j];
                    j++;
                }
                k++;
            }

            while (i < l)
            {
                array[k] = tempLeft[i];
                i++;
                k++;
            }

            while (j < r)
            {
                array[k] = tempRight[j];
                j++;
                k++;
            }
        }
    }
}
