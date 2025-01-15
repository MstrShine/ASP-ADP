namespace HAN.ASD.ADP.DataStructures.HashTable
{
    public class HashEntry<T> where T : IComparable<T>
    {
        public string Key { get; set; }

        public T Value { get; set; }

        public bool IsDeleted { get; set; }

        public HashEntry(string key, T value)
        {
            Key = key;
            Value = value;
            IsDeleted = false;
        }
    }
}
