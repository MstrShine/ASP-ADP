namespace HAN.ASD.ADP.Sorting
{
    public static class MergeSort<T> where T : class, IComparable
    {
        public static void Sort(ref T[] array)
        {
            Split(ref array, 0, array.Length - 1);
        }

        private static void Split(ref T[] array, int left, int right)
        {
            if (left < right)
            {
                int center = (left + right) / 2;
                Split(ref array, left, center);
                Split(ref array, center + 1, right);
                Merge(ref array, left, center, right);
            }
        }

        public static void Merge(ref T[] array, int left, int middle, int right)
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

            while (i <= l && j <= r)
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

            while (i <= l)
            {
                array[k] = tempLeft[i];
                i++;
                k++;
            }

            while (j <= r)
            {
                array[j] = tempRight[j];
                j++;
                k++;
            }
        }
    }
}
