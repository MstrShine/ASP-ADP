using HAN.ASD.ADP.Datasets;
using HAN.ASD.ADP.DataStructures.BinaryTree;
using HAN.ASD.ADP.Helpers;
using System.Diagnostics;

namespace HAN.ASD.ADP.Test.DataStructures
{
    [TestClass]
    public class BinaryTreeTest
    {
        private Stopwatch Watch = new Stopwatch();

        private SortingDataset _dataSet;

        [TestInitialize]
        public void Test_Init()
        {
            var dataset = JsonHelper.LoadJson<SortingDataset>(".\\Datasets\\Raw\\sorting.json");
            if (dataset == null)
            {
                _dataSet = new SortingDataset();
                return;
            }
            _dataSet = dataset;
        }

        [TestMethod]
        public void Insert10()
        {
            var tree = new BinaryTree<int>();
            Watch.Restart();
            tree.Insert(5);
            tree.Insert(7);
            tree.Insert(6);
            tree.Insert(3);
            tree.Insert(4);
            tree.Insert(2);
            tree.Insert(1);
            tree.Insert(8);
            tree.Insert(9);
            tree.Insert(10);
            Watch.Stop();

            Console.WriteLine($"Inserted 10: {Watch}");
            tree.Print();
        }

        [TestMethod]
        public void Insert10FindMax()
        {
            var tree = new BinaryTree<int>();
            Watch.Restart();
            tree.Insert(5);
            tree.Insert(7);
            tree.Insert(6);
            tree.Insert(3);
            tree.Insert(4);
            tree.Insert(2);
            tree.Insert(1);
            tree.Insert(8);
            tree.Insert(9);
            tree.Insert(10);
            Watch.Stop();

            Console.WriteLine($"Inserted 10: {Watch}");

            Watch.Restart();
            var max = tree.Max();
            Watch.Stop();
            Assert.IsTrue(max == 10);

            Console.WriteLine($"Find Max: {Watch}");
        }

        [TestMethod]
        public void Insert10FindMin()
        {
            var tree = new BinaryTree<int>();
            Watch.Restart();
            tree.Insert(5);
            tree.Insert(7);
            tree.Insert(6);
            tree.Insert(3);
            tree.Insert(4);
            tree.Insert(2);
            tree.Insert(1);
            tree.Insert(8);
            tree.Insert(9);
            tree.Insert(10);
            Watch.Stop();

            Console.WriteLine($"Inserted 10: {Watch}");

            Watch.Restart();
            var min = tree.Min();
            Watch.Stop();
            Assert.IsTrue(min == 1);

            Console.WriteLine($"Find Min: {Watch}");
        }

        [TestMethod]
        public void Insert10Find()
        {
            var tree = new BinaryTree<int>();
            Watch.Restart();
            tree.Insert(5);
            tree.Insert(7);
            tree.Insert(6);
            tree.Insert(3);
            tree.Insert(4);
            tree.Insert(2);
            tree.Insert(1);
            tree.Insert(8);
            tree.Insert(9);
            tree.Insert(10);
            Watch.Stop();

            Console.WriteLine($"Inserted 10: {Watch}");

            Watch.Restart();
            var found = tree.Find(4);
            Watch.Stop();
            Assert.IsTrue(found == 4);

            Console.WriteLine($"Found some: {Watch}");
        }

        [TestMethod]
        public void Insert10RemoveSome()
        {
            var tree = new BinaryTree<int>();
            Watch.Restart();
            tree.Insert(5);
            tree.Insert(7);
            tree.Insert(6);
            tree.Insert(3);
            tree.Insert(4);
            tree.Insert(2);
            tree.Insert(1);
            tree.Insert(8);
            tree.Insert(9);
            tree.Insert(10);
            Watch.Stop();

            Console.WriteLine($"Inserted 10: {Watch}");

            Watch.Restart();
            tree.Remove(2);
            Watch.Stop();

            tree.Print();

            try
            {
                tree.Find(2);
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
                Assert.IsTrue(true);
            }
        }

        [TestMethod]
        public void DataSet_Insert_LijstAflopend2()
        {
            var tree = new BinaryTree<int>();
            var lijst = _dataSet.lijst_aflopend_2;
            Watch.Restart();
            foreach (var item in lijst)
            {
                tree.Insert(item);
            }
            Watch.Stop();

            Console.WriteLine($"Insert lijst {Watch}");
        }

        [TestMethod]
        public void DataSet_Insert_LijstOplopend2()
        {
            var tree = new BinaryTree<int>();
            var lijst = _dataSet.lijst_oplopend_2;
            Watch.Restart();
            foreach (var item in lijst)
            {
                tree.Insert(item);
            }
            Watch.Stop();

            Console.WriteLine($"Insert lijst {Watch}");
        }

        [TestMethod]
        public void DataSet_Insert_LijstFloat8001()
        {
            var tree = new BinaryTree<float>();
            var lijst = _dataSet.lijst_float_8001;
            Watch.Restart();
            foreach (var item in lijst)
            {
                tree.Insert(item);
            }
            Watch.Stop();

            Console.WriteLine($"Insert lijst {Watch}");
        }

        [TestMethod]
        public void DataSet_Insert_LijstGesorteerdAflopend3()
        {
            var tree = new BinaryTree<int>();
            var lijst = _dataSet.lijst_gesorteerd_aflopend_3;
            Watch.Restart();
            foreach (var item in lijst)
            {
                tree.Insert(item);
            }
            Watch.Stop();

            Console.WriteLine($"Insert lijst {Watch}");
        }

        [TestMethod]
        public void DataSet_Insert_LijstGesorteerdOplopend3()
        {
            var tree = new BinaryTree<int>();
            var lijst = _dataSet.lijst_gesorteerd_oplopend_3;
            Watch.Restart();
            foreach (var item in lijst)
            {
                tree.Insert(item);
            }
            Watch.Stop();

            Console.WriteLine($"Insert lijst {Watch}");
        }

        [TestMethod]
        public void DataSet_Insert_LijstHerhaald1000()
        {
            var tree = new BinaryTree<int>();
            var lijst = _dataSet.lijst_herhaald_1000;
            Watch.Restart();
            foreach (var item in lijst)
            {
                tree.Insert(item);
            }
            Watch.Stop();

            Console.WriteLine($"Insert lijst {Watch}");
        }

        [TestMethod]
        public void DataSet_Insert_LijstLeeg()
        {
            var tree = new BinaryTree<int>();
            var lijst = _dataSet.lijst_leeg_0;
            Watch.Restart();
            foreach (var item in lijst)
            {
                tree.Insert(item);
            }
            Watch.Stop();

            Console.WriteLine($"Insert lijst {Watch}");
        }

        //[TestMethod]
        //public void DataSet_Insert_LijstOplopend10000()
        //{
        //    var tree = new BinaryTree<int>();
        //    var lijst = _dataSet.lijst_oplopend_10000;
        //    Watch.Restart();
        //    foreach (var item in lijst)
        //    {
        //        tree.Insert(item);
        //    }
        //    Watch.Stop();

        //    Console.WriteLine($"Insert lijst {Watch}");
        //}

        [TestMethod]
        public void DataSet_Insert_LijstWillekeurig10000()
        {
            var tree = new BinaryTree<int>();
            var lijst = _dataSet.lijst_willekeurig_10000;
            Watch.Restart();
            foreach (var item in lijst)
            {
                tree.Insert(item);
            }
            Watch.Stop();

            Console.WriteLine($"Insert lijst {Watch}");
        }

        [TestMethod]
        public void DataSet_Insert_LijstWillekeurig10000_FindMiddle()
        {
            var tree = new BinaryTree<int>();
            var lijst = _dataSet.lijst_willekeurig_10000;
            Watch.Restart();
            foreach (var item in lijst)
            {
                tree.Insert(item);
            }
            Watch.Stop();

            Console.WriteLine($"Insert lijst {Watch}");

            Watch.Restart();
            var found = tree.Find(lijst[lijst.Length / 2]);
            Watch.Stop();

            Assert.AreEqual(lijst[lijst.Length / 2], found);

            Console.WriteLine($"Found middle {Watch}");
        }

        [TestMethod]
        public void DataSet_Insert_LijstWillekeurig10000_FindMin()
        {
            var tree = new BinaryTree<int>();
            var lijst = _dataSet.lijst_willekeurig_10000;
            Watch.Restart();
            foreach (var item in lijst)
            {
                tree.Insert(item);
            }
            Watch.Stop();

            Console.WriteLine($"Insert lijst {Watch}");

            Watch.Restart();
            var found = tree.Min();
            Watch.Stop();

            Console.WriteLine($"Found min {Watch}");
        }

        [TestMethod]
        public void DataSet_Insert_LijstWillekeurig10000_FindMax()
        {
            var tree = new BinaryTree<int>();
            var lijst = _dataSet.lijst_willekeurig_10000;
            Watch.Restart();
            foreach (var item in lijst)
            {
                tree.Insert(item);
            }
            Watch.Stop();

            Console.WriteLine($"Insert lijst {Watch}");

            Watch.Restart();
            var found = tree.Max();
            Watch.Stop();

            Console.WriteLine($"Found max {Watch}");
        }

        [TestMethod]
        public void DataSet_Insert_LijstWillekeurig3()
        {
            var tree = new BinaryTree<int>();
            var lijst = _dataSet.lijst_willekeurig_3;
            Watch.Restart();
            foreach (var item in lijst)
            {
                tree.Insert(item);
            }
            Watch.Stop();

            Console.WriteLine($"Insert lijst {Watch}");
        }

        [TestMethod]
        public void DataSet_Insert_LijstPizzas()
        {
            var tree = new BinaryTree<Pizza>();
            var lijst = _dataSet.lijst_pizzas;
            Watch.Restart();
            foreach (var item in lijst)
            {
                tree.Insert(item);
            }
            Watch.Stop();

            Console.WriteLine($"Insert lijst {Watch}");
        }
    }
}
