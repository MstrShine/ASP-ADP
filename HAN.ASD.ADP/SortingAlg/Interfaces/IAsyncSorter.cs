namespace HAN.ASD.ADP.SortingAlg.Interfaces
{
    public interface IAsyncSorter
    {
        Task Sort<T>(T[] array) where T : IComparable<T>;
    }
}
