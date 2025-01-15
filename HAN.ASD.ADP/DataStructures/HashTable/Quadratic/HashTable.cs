namespace HAN.ASD.ADP.DataStructures.HashTable.Quadratic
{
    public class HashTable<T> : IHashTable<T> where T : IComparable<T>
    {
        private HashEntry<T>[] _table;
        private int _size;
        private int _capacity;
        private const double LoadFactor = 0.5;

        public HashTable(int initialCapacity = 16)
        {
            _capacity = initialCapacity;
            _table = new HashEntry<T>[_capacity];
            _size = 0;
        }

        public void Insert(string key, T value)
        {
            if (_size >= _capacity * LoadFactor)
            {
                Resize();
            }

            var index = Hash(key);
            int i = 0;

            while (_table[(index + i * i) % _capacity] != null && !_table[(index + i * i) % _capacity].IsDeleted)
            {
                if (_table[(index + i * i) % _capacity].Key == key)
                {
                    throw new ArgumentException($"Key '{key}' already exists in the hash table.");
                }
                i++;
            }

            _table[(index + i * i) % _capacity] = new HashEntry<T>(key, value);
            _size++;
        }

        public T Get(string key)
        {
            var index = Hash(key);
            int i = 0;

            while (_table[(index + i * i) % _capacity] != null)
            {
                int probeIndex = (index + i * i) % _capacity;

                if (!_table[probeIndex].IsDeleted && _table[probeIndex].Key == key)
                {
                    return _table[probeIndex].Value;
                }

                i++;
            }

            throw new KeyNotFoundException($"Key '{key}' not found in the hash table.");
        }

        public T Delete(string key)
        {
            var index = Hash(key);
            int i = 0;

            while (_table[(index + i * i) % _capacity] != null)
            {
                int probeIndex = (index + i * i) % _capacity;

                if (!_table[probeIndex].IsDeleted && _table[probeIndex].Key == key)
                {
                    _table[probeIndex].IsDeleted = true;
                    _size--;
                    return _table[probeIndex].Value;
                }

                i++;
            }

            throw new KeyNotFoundException($"Key '{key}' not found in the hash table.");
        }

        public T Update(string key, T value)
        {
            var index = Hash(key);
            int i = 0;

            while (_table[(index + i * i) % _capacity] != null)
            {
                int probeIndex = (index + i * i) % _capacity;

                if (!_table[probeIndex].IsDeleted && _table[probeIndex].Key == key)
                {
                    var oldValue = _table[probeIndex].Value;
                    _table[probeIndex].Value = value;
                    return oldValue;
                }

                i++;
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
