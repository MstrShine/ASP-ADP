namespace HAN.ASD.ADP.DataStructures.HashTable.Linear
{
    public class HashTable<T> : IHashTable<T> where T : IComparable<T>
    {
        private HashEntry<T>[] _table;
        private int _size;
        private int _capacity;
        private const double LoadFactor = 0.75;

        public HashTable(int initialCapacity = 16)
        {
            _capacity = initialCapacity;
            _table = new HashEntry<T>[initialCapacity];
            _size = 0;
        }

        public void Insert(string key, T value)
        {
            if (_size >= _capacity * LoadFactor)
            {
                Resize();
            }

            var index = Hash(key);

            while (_table[index] != null && !_table[index].IsDeleted)
            {
                if (_table[index].Key == key)
                {
                    throw new ArgumentException($"Key '{key}' already exists in the hash table.");
                }
                index = (index + 1) % _capacity;
            }

            _table[index] = new HashEntry<T>(key, value);
            _size++;
        }

        public T Get(string key)
        {
            var index = Hash(key);

            for (int i = 0; i < _capacity; i++)
            {
                if (_table[index] == null)
                {
                    break;
                }

                if (!_table[index].IsDeleted && _table[index].Key == key)
                {
                    return _table[index].Value;
                }

                index = (index + 1) % _capacity;
            }

            throw new KeyNotFoundException($"Key '{key}' not found in the hash table.");
        }

        public T Delete(string key)
        {
            var index = Hash(key);

            for (int i = 0; i < _capacity; i++)
            {
                if (_table[index] == null)
                {
                    break;
                }

                if (!_table[index].IsDeleted && _table[index].Key == key)
                {
                    _table[index].IsDeleted = true;
                    _size--;
                    return _table[index].Value;
                }

                index = (index + 1) % _capacity;
            }

            throw new KeyNotFoundException($"Key '{key}' not found in the hash table.");
        }

        public T Update(string key, T value)
        {
            var index = Hash(key);

            for (int i = 0; i < _capacity; i++)
            {
                if (_table[index] == null)
                {
                    break;
                }

                if (!_table[index].IsDeleted && _table[index].Key == key)
                {
                    var oldValue = _table[index].Value;
                    _table[index].Value = value;
                    return oldValue;
                }

                index = (index + 1) % _capacity;
            }

            throw new KeyNotFoundException($"Key '{key}' not found in the hash table.");
        }

        private int Hash(string key)
        {
            return Math.Abs(key.GetHashCode()) % _capacity;
        }

        private void Resize()
        {
            var oldTable = _table;
            _capacity *= 2;
            _table = new HashEntry<T>[_capacity];
            _size = 0;

            foreach (var entry in oldTable)
            {
                if (entry != null && !entry.IsDeleted)
                {
                    Insert(entry.Key, entry.Value);
                }
            }
        }
    }
}
