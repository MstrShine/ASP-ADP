using HAN.ASD.ADP.DataStructures.Stack;
using System.Diagnostics;

namespace HAN.ASD.ADP.Test.DataStructures
{
    [TestClass]
    public class StackTest
    {
        private Stopwatch Watch = new Stopwatch();

        [TestMethod]
        public void Push10AndPop()
        {
            var stack = new ADPStack<int>();
            Watch.Restart();
            for (int i = 0; i < 10; i++)
            {
                stack.Push(i);
            }
            Watch.Stop();
            Console.WriteLine($"Adding 10: {Watch}");

            Assert.AreEqual(10, stack.Size());

            Watch.Restart();
            for (int i = 9; i > -1; i--)
            {
                var pop = stack.Pop();
                Assert.AreEqual(i, pop);
            }
            Watch.Stop();
            Console.WriteLine($"Popping 10: {Watch}");

            Assert.IsTrue(stack.IsEmpty());
        }

        [TestMethod]
        public void Push10AndTopThenPop()
        {
            var stack = new ADPStack<int>();
            Watch.Restart();
            for (int i = 0; i < 10; i++)
            {
                stack.Push(i);
            }
            Watch.Stop();
            Console.WriteLine($"Adding 10: {Watch}");

            Assert.AreEqual(10, stack.Size());

            Watch.Restart();
            for (int i = 0; i < 10; i++)
            {
                var top = stack.Top();
                var pop = stack.Pop();
                Assert.AreEqual(top, pop);
            }
            Watch.Stop();
            Console.WriteLine($"Topping and Popping 10: {Watch}");

            Assert.IsTrue(stack.IsEmpty());
        }

        [TestMethod]
        public void PerformanceTest_Push100000AndPop_NotPropperSize()
        {
            var stack = new ADPStack<int>();
            Watch.Restart();
            for (int i = 0; i < 100000; i++)
            {
                stack.Push(i);
            }
            Watch.Stop();
            Console.WriteLine($"Adding 100000: {Watch}");

            Assert.AreEqual(100000, stack.Size());

            Watch.Restart();
            while (!stack.IsEmpty())
            {
                var pop = stack.Pop();
            }
            Watch.Stop();
            Console.WriteLine($"Popping 100000: {Watch}");

            Assert.IsTrue(stack.IsEmpty());
        }

        [TestMethod]
        public void PerformanceTest_Push100000AndPop_PropperSize()
        {
            var stack = new ADPStack<int>(100000);
            Watch.Restart();
            for (int i = 0; i < 100000; i++)
            {
                stack.Push(i);
            }
            Watch.Stop();
            Console.WriteLine($"Adding 100000: {Watch}");

            Assert.AreEqual(100000, stack.Size());

            Watch.Restart();
            while (!stack.IsEmpty())
            {
                var pop = stack.Pop();
            }
            Watch.Stop();
            Console.WriteLine($"Popping 100000: {Watch}");

            Assert.IsTrue(stack.IsEmpty());
        }
    }
}
