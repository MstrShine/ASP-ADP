using HAN.ASD.ADP.Datasets;
using HAN.ASD.ADP.Helpers;
using System.Diagnostics;

namespace HAN.ASD.ADP.Test.DataStructures
{
    [TestClass]
    public class HashTableTest
    {
        private Stopwatch Watch = new Stopwatch();

        public HashTabelSleutelWaardesDataset _dataSet;

        [TestInitialize]
        public void TestInit()
        {
            var dataset = JsonHelper.LoadJson<HashTabelSleutelWaardesDataset>(".\\Datasets\\Raw\\hashing.json");
            if (dataset == null)
            {
                _dataSet = new HashTabelSleutelWaardesDataset();
                return;
            }

            _dataSet = dataset;
        }

        [TestMethod]
        public void Linear_Insert10()
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
        public void Linear_Insert10Get10()
        {
            var table = new ADP.DataStructures.HashTable.Linear.HashTable<int>();
            Watch.Restart();
            for (int i = 0; i < 10; i++)
            {
                table.Insert(i.ToString(), i);
            }
            Watch.Stop();

            Console.WriteLine($"Insert {Watch}");

            Watch.Restart();
            for (int i = 0; i < 10; ++i)
            {
                var got = table.Get(i.ToString());
                Assert.AreEqual(i, got);
            }
            Watch.Stop();

            Console.WriteLine($"Getting all 10 {Watch}");
        }

        [TestMethod]
        public void Linear_Insert10Delete10()
        {
            var table = new ADP.DataStructures.HashTable.Linear.HashTable<int>();
            Watch.Restart();
            for (int i = 0; i < 10; i++)
            {
                table.Insert(i.ToString(), i);
            }
            Watch.Stop();

            Console.WriteLine($"Insert {Watch}");

            Watch.Restart();
            for (int i = 0; i < 10; ++i)
            {
                var deleted = table.Delete(i.ToString());
                Assert.AreEqual(i, deleted);
            }
            Watch.Stop();

            Console.WriteLine($"Deleting all 10 {Watch}");
        }

        [TestMethod]
        public void Linear_Insert10Update10()
        {
            var table = new ADP.DataStructures.HashTable.Linear.HashTable<int>();
            Watch.Restart();
            for (int i = 0; i < 10; i++)
            {
                table.Insert(i.ToString(), i);
            }
            Watch.Stop();

            Console.WriteLine($"Insert {Watch}");

            Watch.Restart();
            int updateVal = 10;
            for (int i = 0; i < 10; ++i)
            {
                var updated = table.Update(i.ToString(), updateVal--);
                Assert.AreEqual(i, updated);
            }
            Watch.Stop();

            Console.WriteLine($"Deleting all 10 {Watch}");
        }

        [TestMethod]
        public void Linear_InsertDataset()
        {
            var table = new ADP.DataStructures.HashTable.Linear.HashTable<int>();
            var properties = typeof(HashTabelSleutelWaardesDataset).GetProperties();
            Watch.Restart();
            foreach (var property in properties)
            {
                var obj = (int[])property.GetValue(_dataSet);
                foreach (var i in obj)
                {
                    try
                    {
                        table.Insert(property.Name, i);
                    }
                    catch (Exception) { }
                }
            }
            Watch.Stop();

            Console.WriteLine(Watch.ToString());
        }

        [TestMethod]
        public void Quad_Insert10()
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

        [TestMethod]
        public void Quad_Insert10Get10()
        {
            var table = new ADP.DataStructures.HashTable.Quadratic.HashTable<int>();
            Watch.Restart();
            for (int i = 0; i < 10; i++)
            {
                table.Insert(i.ToString(), i);
            }
            Watch.Stop();

            Console.WriteLine($"Insert {Watch}");

            Watch.Restart();
            for (int i = 0; i < 10; ++i)
            {
                var got = table.Get(i.ToString());
                Assert.AreEqual(i, got);
            }
            Watch.Stop();

            Console.WriteLine($"Getting all 10 {Watch}");
        }

        [TestMethod]
        public void Quad_Insert10Delete10()
        {
            var table = new ADP.DataStructures.HashTable.Quadratic.HashTable<int>();
            Watch.Restart();
            for (int i = 0; i < 10; i++)
            {
                table.Insert(i.ToString(), i);
            }
            Watch.Stop();

            Console.WriteLine($"Insert {Watch}");

            Watch.Restart();
            for (int i = 0; i < 10; ++i)
            {
                var deleted = table.Delete(i.ToString());
                Assert.AreEqual(i, deleted);
            }
            Watch.Stop();

            Console.WriteLine($"Deleting all 10 {Watch}");
        }

        [TestMethod]
        public void Quad_Insert10Update10()
        {
            var table = new ADP.DataStructures.HashTable.Quadratic.HashTable<int>();
            Watch.Restart();
            for (int i = 0; i < 10; i++)
            {
                table.Insert(i.ToString(), i);
            }
            Watch.Stop();

            Console.WriteLine($"Insert {Watch}");

            Watch.Restart();
            int updateVal = 10;
            for (int i = 0; i < 10; ++i)
            {
                var updated = table.Update(i.ToString(), updateVal--);
                Assert.AreEqual(i, updated);
            }
            Watch.Stop();

            Console.WriteLine($"Deleting all 10 {Watch}");
        }

        [TestMethod]
        public void Quad_InsertDataset()
        {
            var table = new ADP.DataStructures.HashTable.Quadratic.HashTable<int>();
            var properties = typeof(HashTabelSleutelWaardesDataset).GetProperties();
            Watch.Restart();
            foreach (var property in properties)
            {
                var obj = (int[])property.GetValue(_dataSet);
                foreach (var i in obj)
                {
                    try
                    {
                        table.Insert(property.Name, i);
                    }
                    catch (Exception) { }
                }
            }
            Watch.Stop();

            Console.WriteLine(Watch.ToString());
        }

        [TestMethod]
        public void Performance_Linear_Insert10000()
        {
            var table = new ADP.DataStructures.HashTable.Linear.HashTable<int>();
            Watch.Restart();
            for (int i = 0; i < 10000; i++)
            {
                table.Insert(i.ToString(), i);
            }
            Watch.Stop();

            Console.WriteLine($"Insert {Watch}");
        }

        [TestMethod]
        public void Performance_Quad_Insert10000()
        {
            var table = new ADP.DataStructures.HashTable.Quadratic.HashTable<int>();
            Watch.Restart();
            for (int i = 0; i < 10000; i++)
            {
                table.Insert(i.ToString(), i);
            }
            Watch.Stop();

            Console.WriteLine($"Insert {Watch}");
        }

        [TestMethod]
        public void Performance_Linear_Delete10000()
        {
            var table = new ADP.DataStructures.HashTable.Linear.HashTable<int>();
            Watch.Restart();
            for (int i = 0; i < 10000; i++)
            {
                table.Insert(i.ToString(), i);
            }
            Watch.Stop();

            Console.WriteLine($"Insert {Watch}");

            Watch.Restart();
            for (int i = 0; i < 10000; i++)
            {
                table.Delete(i.ToString());
            }
            Watch.Stop();

            Console.WriteLine($"Delete {Watch}");
        }

        [TestMethod]
        public void Performance_Quad_Delete10000()
        {
            var table = new ADP.DataStructures.HashTable.Quadratic.HashTable<int>();
            Watch.Restart();
            for (int i = 0; i < 10000; i++)
            {
                table.Insert(i.ToString(), i);
            }
            Watch.Stop();

            Console.WriteLine($"Insert {Watch}");

            Watch.Restart();
            for (int i = 0; i < 10000; i++)
            {
                table.Delete(i.ToString());
            }
            Watch.Stop();

            Console.WriteLine($"Delete {Watch}");
        }

        [TestMethod]
        public void Performance_Linear_Get10000()
        {
            var table = new ADP.DataStructures.HashTable.Linear.HashTable<int>();
            Watch.Restart();
            for (int i = 0; i < 10000; i++)
            {
                table.Insert(i.ToString(), i);
            }
            Watch.Stop();

            Console.WriteLine($"Insert {Watch}");

            Watch.Restart();
            for (int i = 0; i < 10000; i++)
            {
                table.Get(i.ToString());
            }
            Watch.Stop();

            Console.WriteLine($"Delete {Watch}");
        }

        [TestMethod]
        public void Performance_Quad_Get10000()
        {
            var table = new ADP.DataStructures.HashTable.Quadratic.HashTable<int>();
            Watch.Restart();
            for (int i = 0; i < 10000; i++)
            {
                table.Insert(i.ToString(), i);
            }
            Watch.Stop();

            Console.WriteLine($"Insert {Watch}");

            Watch.Restart();
            for (int i = 0; i < 10000; i++)
            {
                table.Get(i.ToString());
            }
            Watch.Stop();

            Console.WriteLine($"Delete {Watch}");
        }

        [TestMethod]
        public void Performance_Linear_Update10000()
        {
            var table = new ADP.DataStructures.HashTable.Linear.HashTable<int>();
            Watch.Restart();
            for (int i = 0; i < 10000; i++)
            {
                table.Insert(i.ToString(), i);
            }
            Watch.Stop();

            Console.WriteLine($"Insert {Watch}");

            Watch.Restart();
            var toUpdate = 10000;
            for (int i = 0; i < 10000; i++)
            {
                table.Update(i.ToString(), toUpdate--);
            }
            Watch.Stop();

            Console.WriteLine($"Delete {Watch}");
        }

        [TestMethod]
        public void Performance_Quad_Update10000()
        {
            var table = new ADP.DataStructures.HashTable.Quadratic.HashTable<int>();
            Watch.Restart();
            for (int i = 0; i < 10000; i++)
            {
                table.Insert(i.ToString(), i);
            }
            Watch.Stop();

            Console.WriteLine($"Insert {Watch}");

            Watch.Restart();
            var toUpdate = 10000;
            for (int i = 0; i < 10000; i++)
            {
                table.Update(i.ToString(), toUpdate--);
            }
            Watch.Stop();

            Console.WriteLine($"Delete {Watch}");
        }
    }
}
