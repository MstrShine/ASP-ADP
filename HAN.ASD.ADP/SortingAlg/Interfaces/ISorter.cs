namespace HAN.ASD.ADP.SortingAlg.Interfaces
{
    public interface ISorter
    {
        void Sort<T>(T[] array) where T : IComparable<T>;
    }
}
