using HAN.ASD.ADP.DataStructures.DLList;
using System.Diagnostics;

namespace HAN.ASD.ADP.Test.DataStructures
{
    [TestClass]
    public class DoublyLinkedListTest
    {
        private Stopwatch Watch = new Stopwatch();

        [TestMethod]
        public void Adding10Deleting10()
        {
            var dlist = new DoublyLinkedList<int>();
            Watch.Restart();
            for (int i = 0; i < 10; i++)
            {
                dlist.Add(i);
            }
            Watch.Stop();

            Console.WriteLine(Watch.ToString());

            Watch.Restart();
            for (int i = 0; i < 10; i++)
            {
                dlist.Remove(element: i);
            }
            Watch.Stop();

            Console.WriteLine(Watch.ToString());
        }
    }
}
