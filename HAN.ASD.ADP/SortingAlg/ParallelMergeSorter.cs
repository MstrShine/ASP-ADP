using HAN.ASD.ADP.SortingAlg.Interfaces;

namespace HAN.ASD.ADP.SortingAlg
{
    public class ParallelMergeSorter : IAsyncSorter
    {
        private const int CUTOFF = 1000;

        public async Task Sort<T>(T[] array) where T : IComparable<T>
        {
            await AsyncSplit(array, 0, array.Length - 1);
        }

        private async Task AsyncSplit<T>(T[] array, int left, int right) where T : IComparable<T>
        {
            if (left >= right)
                return;

            if (right - left <= CUTOFF)
            {
                SyncSplit(array, left, right);
            }
            else
            {
                int center = (left + right) / 2;
                var leftSplit = AsyncSplit(array, left, center);
                var rightSplit = AsyncSplit(array, center + 1, right);

                await Task.WhenAll(leftSplit, rightSplit);

                Merge(array, left, center, right);
            }
        }

        public void SyncSplit<T>(T[] array, int left, int right) where T : IComparable<T>
        {
            if (left < right)
            {
                int center = (left + right) / 2;
                SyncSplit(array, left, center);
                SyncSplit(array, center + 1, right);
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
