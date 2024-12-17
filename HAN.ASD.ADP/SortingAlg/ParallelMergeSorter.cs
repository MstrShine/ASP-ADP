using HAN.ASD.ADP.SortingAlg.Interfaces;

namespace HAN.ASD.ADP.SortingAlg
{
    public class ParallelMergeSorter : IAsyncSorter
    {
        private const int CUTOFF = 1000;

        public async Task Sort<T>(T[] array) where T : IComparable<T>
        {
            var buffer = new T[array.Length];
            await AsyncSplit(array, 0, array.Length - 1, buffer);
        }

        private async Task AsyncSplit<T>(T[] array, int left, int right, T[] buffer) where T : IComparable<T>
        {
            if (left >= right)
                return;

            if (right - left <= CUTOFF)
            {
                SyncSplit(array, left, right, buffer);
            }
            else
            {
                int center = (left + right) / 2;
                var leftSplit = AsyncSplit(array, left, center, buffer);
                var rightSplit = AsyncSplit(array, center + 1, right, buffer);

                await Task.WhenAll(leftSplit, rightSplit);

                Merge(array, left, center, right, buffer);
            }
        }

        public void SyncSplit<T>(T[] array, int left, int right, T[] buffer) where T : IComparable<T>
        {
            if (left < right)
            {
                int center = (left + right) / 2;
                SyncSplit(array, left, center, buffer);
                SyncSplit(array, center + 1, right, buffer);

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
