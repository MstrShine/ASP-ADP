using System.Diagnostics;

namespace HAN.ASD.ADP.Test.DataStructures
{
    [TestClass]
    public class HashTableTest
    {
        private Stopwatch Watch = new Stopwatch();

        [TestMethod]
        public void Insert10Linear()
        {
            var table = new ADP.DataStructures.HashTable.Linear.HashTable<int>();
            Watch.Restart();
            for (int i = 0; i < 10; i++)
            {
                table.Insert(i.ToString(), i);
            }
            Watch.Stop();

            Console.WriteLine(Watch.ToString());
        }

        [TestMethod]
        public void Insert10Quad()
        {
            var table = new ADP.DataStructures.HashTable.Quadratic.HashTable<int>();
            Watch.Restart();
            for (int i = 0; i < 10; i++)
            {
                table.Insert(i.ToString(), i);
            }
            Watch.Stop();

            Console.WriteLine(Watch.ToString());
        }
    }
}
