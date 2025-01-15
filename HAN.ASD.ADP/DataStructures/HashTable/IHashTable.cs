namespace HAN.ASD.ADP.DataStructures.HashTable
{
    public interface IHashTable<T> where T : IComparable<T>
    {
        void Insert(string key, T value);
        T Get(string key);
        T Delete(string key);
        T Update(string key, T value);
    }
}
