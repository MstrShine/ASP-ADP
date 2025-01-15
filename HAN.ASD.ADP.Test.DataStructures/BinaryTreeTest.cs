using HAN.ASD.ADP.DataStructures.BinaryTree;
using System.Diagnostics;

namespace HAN.ASD.ADP.Test.DataStructures
{
    [TestClass]
    public class BinaryTreeTest
    {
        private Stopwatch Watch = new Stopwatch();

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
    }
}
