using HAN.ASD.ADP.DataStructures.BinaryTree;
using System.Diagnostics;

namespace HAN.ASD.ADP.Test.DataStructures
{
    [TestClass]
    public class AVLTreeTest
    {
        private Stopwatch Watch = new Stopwatch();

        [TestMethod]
        public void Insert10()
        {
            var tree = new AVLTree<int>();
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

            Console.WriteLine(Watch.ToString());
            tree.Print();
        }
    }
}
