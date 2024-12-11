namespace HAN.ASD.ADP.SortingAlg
{
    public static class SelectionSorter
    {
        public static void Sort<T>(T[] array) where T : class, IComparable
        {
            for (int i = 0; i < array.Length; i++)
            {
                int minIndex = i;
                for (int j = 0; j < array.Length; j++)
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
