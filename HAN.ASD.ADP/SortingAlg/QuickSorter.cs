namespace HAN.ASD.ADP.SortingAlg
{
    public static class QuickSorter<T> where T : IComparable
    {
        public static void QuickSort(T[] array)
        {
            Sort(array, 0, array.Length - 1);
        }

        private static void Sort(T[] array, int left, int right)
        {
            if (left < right)
            {
                var pivotIndex = Partition(array, left, right);
                Sort(array, left, pivotIndex - 1);
                Sort(array, pivotIndex + 1, right);
            }
        }

        private static int Partition(T[] array, int left, int right)
        {
            var pivot = SelectMedianPivot(array, left, (left + right) / 2, right);
            Swap(array, pivot.PivotIndex, right);

            int i = left - 1;
            for (int j = left; j < right; j++)
            {
                if (array[j].CompareTo(pivot.PivotObject) <= 0)
                {
                    i++;
                    Swap(array, i, j);
                }
            }

            Swap(array, i + 1, right);

            return i + 1;
        }

        private record MedianPivot(T PivotObject, int PivotIndex);
        private static MedianPivot SelectMedianPivot(T[] array, int l, int m, int r)
        {
            var left = array[l];
            var right = array[r];
            var middle = array[m];

            if ((left.CompareTo(middle) < 0 && left.CompareTo(right) > 0) || (left.CompareTo(middle) > 0 && left.CompareTo(right) < 0)) return new MedianPivot(left, l);
            else if ((middle.CompareTo(left) < 0 && middle.CompareTo(right) > 0) || (middle.CompareTo(left) > 0 && middle.CompareTo(right) < 0)) return new MedianPivot(middle, m);
            else return new MedianPivot(right, r);
        }

        private static void Swap(T[] array, int i, int j)
        {
            var temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
