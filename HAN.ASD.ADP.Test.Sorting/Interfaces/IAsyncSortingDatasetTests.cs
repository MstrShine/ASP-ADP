namespace HAN.ASD.ADP.Test.Sorting.Interfaces
{
    public interface IAsyncSortingDatasetTests
    {
        Task SortAflopend2();
        Task SortOplopend2();
        Task SortFloat8001();
        Task SortGesorteerdAflopend3();
        Task SortGesorteerdOplopend3();
        Task SortLijstHerhaald1000();
        Task SortLeeg0();
        Task SortNull1();
        Task SortNull3();
        Task SortOnsorteerbaar3();
        Task LijstOplopend10000();
        Task SortWillekeurig1000();
        Task SortWillekeurig3();
    }
}
