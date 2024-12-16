using HAN.ASD.ADP.DataStructures.PQueue;
using System.Diagnostics;

namespace HAN.ASD.ADP.Test.DataStructures
{
    [TestClass]
    public class PriorityQueueTest
    {
        private Stopwatch Watch = new Stopwatch();

        [TestMethod]
        public void Adding10Poll10()
        {
            var pQueue = new PriorityQueue<int>();
            Watch.Restart();
            for (int i = 0; i < 10; i++)
            {
                pQueue.Add(i);
            }
            Watch.Stop();
            Console.WriteLine($"Adding 10: {Watch}");
            Assert.AreEqual(10, pQueue.Size());

            Watch.Restart();
            for (int i = 0; i < 10; i++)
            {
                var poll = pQueue.Poll();
                Assert.AreEqual(i, poll);
            }
            Watch.Stop();
            Console.WriteLine($"Polling 10: {Watch}");
            Assert.AreEqual(0, pQueue.Size());
        }

        [TestMethod]
        public void Adding10PeekingThanPolling()
        {
            var pQueue = new PriorityQueue<int>();
            Watch.Restart();
            for (int i = 0; i < 10; i++)
            {
                pQueue.Add(i);
            }
            Watch.Stop();
            Console.WriteLine($"Adding 10: {Watch}");
            Assert.AreEqual(10, pQueue.Size());

            Watch.Restart();
            for (int i = 0; i < 10; i++)
            {
                var peek = pQueue.Peek();
                var poll = pQueue.Poll();
                Assert.AreEqual(peek, poll);
            }
            Watch.Stop();
            Console.WriteLine($"Peeking and Polling 10: {Watch}");
            Assert.AreEqual(0, pQueue.Size());
        }

        [TestMethod]
        public void PerformanceTest_Adding100000ThenPolling_NotPropperSize()
        {
            var pQueue = new PriorityQueue<int>();
            Watch.Restart();
            for (int i = 0; i < 100000; i++)
            {
                pQueue.Add(i);
            }
            Watch.Stop();
            Console.WriteLine($"Adding 100000: {Watch}");
            Assert.AreEqual(100000, pQueue.Size());

            Watch.Restart();
            for (int i = 0; i < 100000; i++)
            {
                var poll = pQueue.Poll();
                Assert.AreEqual(i, poll);
            }
            Watch.Stop();
            Console.WriteLine($"Polling 100000: {Watch}");
            Assert.AreEqual(0, pQueue.Size());
        }
    }
}
