namespace HAN.ASD.ADP.SortingAlg
{
    public static class InsertionSorter
    {
        public static void Sort<T>(T[] array) where T : IComparable
        {
            for (int i = 1; i < array.Length; i++)
            {
                var toBeInserted = array[i];

                int j = i;
                while (j > 0 && toBeInserted.CompareTo(array[j - 1]) < 0)
                {
                    array[j] = array[j - 1];
                    j--;
                }

                array[j] = toBeInserted;
            }
        }
    }
}
