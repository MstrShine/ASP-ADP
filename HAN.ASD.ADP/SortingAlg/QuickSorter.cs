using HAN.ASD.ADP.SortingAlg.Interfaces;

namespace HAN.ASD.ADP.SortingAlg
{
    public class QuickSorter : ISorter
    {
        public void Sort<T>(T[] array) where T : IComparable<T>
        {
            QuickSort(array, 0, array.Length - 1);
        }

        private static void QuickSort<T>(T[] array, int left, int right) where T : IComparable<T>
        {
            if (left < right)
            {
                var pivotIndex = Partition(array, left, right);
                QuickSort(array, left, pivotIndex - 1);
                QuickSort(array, pivotIndex + 1, right);
            }
        }

        private static int Partition<T>(T[] array, int left, int right) where T : IComparable<T>
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

        private record MedianPivot<T>(T PivotObject, int PivotIndex) where T : IComparable<T>;
        private static MedianPivot<T> SelectMedianPivot<T>(T[] array, int l, int m, int r) where T : IComparable<T>
        {
            var left = array[l];
            var right = array[r];
            var middle = array[m];

            if ((left.CompareTo(middle) < 0 && left.CompareTo(right) > 0) || (left.CompareTo(middle) > 0 && left.CompareTo(right) < 0)) return new MedianPivot<T>(left, l);
            else if ((middle.CompareTo(left) < 0 && middle.CompareTo(right) > 0) || (middle.CompareTo(left) > 0 && middle.CompareTo(right) < 0)) return new MedianPivot<T>(middle, m);
            else return new MedianPivot<T>(right, r);
        }

        private static void Swap<T>(T[] array, int i, int j) where T : IComparable<T>
        {
            var temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
}
