using HAN.ASD.ADP.DataStructures.DArray;
using HAN.ASD.ADP.DataStructures.Deque;
using HAN.ASD.ADP.DataStructures.DLList;
using HAN.ASD.ADP.DataStructures.Stack;
using System.Diagnostics;

namespace HAN.ASD.ADP.Test.DataStructures
{
    [TestClass]
    public class TimeComplexityTests
    {
        private Stopwatch Watch = new Stopwatch();

        #region Deque
        [TestMethod]
        public void Deque_A_WarmUp()
        {
            var deque = new Deque<int>();
            Watch.Restart();
            for (int i = 0; i < 10; i++) { deque.InsertLeft(i); }
            Watch.Stop();
            Console.WriteLine(Watch.ToString());
        }

        [TestMethod]
        public void Deque_Adding10()
        {
            var deque = new Deque<int>();
            Watch.Restart();
            for (int i = 0; i < 10; i++) { deque.InsertLeft(i); }
            Watch.Stop();
            Console.WriteLine(Watch.ToString());
        }

        [TestMethod]
        public void Deque_Adding100()
        {
            var deque = new Deque<int>();
            Watch.Restart();
            for (int i = 0; i < 100; i++) { deque.InsertLeft(i); }
            Watch.Stop();
            Console.WriteLine(Watch.ToString());
        }

        [TestMethod]
        public void Deque_Adding1000()
        {
            var deque = new Deque<int>();
            Watch.Restart();
            for (int i = 0; i < 1000; i++) { deque.InsertLeft(i); }
            Watch.Stop();
            Console.WriteLine(Watch.ToString());
        }

        [TestMethod]
        public void Deque_Adding10000()
        {
            var deque = new Deque<int>();
            Watch.Restart();
            for (int i = 0; i < 10000; i++) { deque.InsertLeft(i); }
            Watch.Stop();
            Console.WriteLine(Watch.ToString());
        }

        [TestMethod]
        public void Deque_Adding100000()
        {
            var deque = new Deque<int>();
            Watch.Restart();
            for (int i = 0; i < 100000; i++) { deque.InsertLeft(i); }
            Watch.Stop();
            Console.WriteLine(Watch.ToString());
        }

        [TestMethod]
        public void Deque_D_WarmUp()
        {
            var deque = new Deque<int>();
            for (int i = 0; i < 10; i++) { deque.InsertLeft(i); }
            Watch.Restart();
            for (int i = 0; i < 10; i++) { deque.DeleteLeft(); }
            Watch.Stop();
            Console.WriteLine(Watch.ToString());
        }

        [TestMethod]
        public void Deque_Deleting10()
        {
            var deque = new Deque<int>();
            for (int i = 0; i < 10; i++) { deque.InsertLeft(i); }
            Watch.Restart();
            for (int i = 0; i < 10; i++) { deque.DeleteLeft(); }
            Watch.Stop();
            Console.WriteLine(Watch.ToString());
        }

        [TestMethod]
        public void Deque_Deleting100()
        {
            var deque = new Deque<int>();
            for (int i = 0; i < 100; i++) { deque.InsertLeft(i); }
            Watch.Restart();
            for (int i = 0; i < 100; i++) { deque.DeleteLeft(); }
            Watch.Stop();
            Console.WriteLine(Watch.ToString());
        }

        [TestMethod]
        public void Deque_Deleting1000()
        {
            var deque = new Deque<int>();
            for (int i = 0; i < 1000; i++) { deque.InsertLeft(i); }
            Watch.Restart();
            for (int i = 0; i < 1000; i++) { deque.DeleteLeft(); }
            Watch.Stop();
            Console.WriteLine(Watch.ToString());
        }

        [TestMethod]
        public void Deque_Deleting10000()
        {
            var deque = new Deque<int>();
            for (int i = 0; i < 10000; i++) { deque.InsertLeft(i); }
            Watch.Restart();
            for (int i = 0; i < 10000; i++) { deque.DeleteLeft(); }
            Watch.Stop();
            Console.WriteLine(Watch.ToString());
        }

        [TestMethod]
        public void Deque_Deleting100000()
        {
            var deque = new Deque<int>();
            for (int i = 0; i < 100000; i++) { deque.InsertLeft(i); }
            Watch.Restart();
            for (int i = 0; i < 100000; i++) { deque.DeleteLeft(); }
            Watch.Stop();
            Console.WriteLine(Watch.ToString());
        }
        #endregion

        #region DoublyLinkedList
        [TestMethod]
        public void DoublyLinkedList_A_WarmUp()
        {
            var dlList = new DoublyLinkedList<int>();
            Watch.Restart();
            for (int i = 0; i < 10; i++) { dlList.Add(i); }
            Watch.Stop();
            Console.WriteLine(Watch.ToString());
        }

        [TestMethod]
        public void DoublyLinkedList_Adding10()
        {
            var dlList = new DoublyLinkedList<int>();
            Watch.Restart();
            for (int i = 0; i < 10; i++) { dlList.Add(i); }
            Watch.Stop();
            Console.WriteLine(Watch.ToString());
        }

        [TestMethod]
        public void DoublyLinkedList_Adding100()
        {
            var dlList = new DoublyLinkedList<int>();
            Watch.Restart();
            for (int i = 0; i < 100; i++) { dlList.Add(i); }
            Watch.Stop();
            Console.WriteLine(Watch.ToString());
        }

        [TestMethod]
        public void DoublyLinkedList_Adding1000()
        {
            var dlList = new DoublyLinkedList<int>();
            Watch.Restart();
            for (int i = 0; i < 1000; i++) { dlList.Add(i); }
            Watch.Stop();
            Console.WriteLine(Watch.ToString());
        }

        [TestMethod]
        public void DoublyLinkedList_Adding10000()
        {
            var dlList = new DoublyLinkedList<int>();
            Watch.Restart();
            for (int i = 0; i < 10000; i++) { dlList.Add(i); }
            Watch.Stop();
            Console.WriteLine(Watch.ToString());
        }

        [TestMethod]
        public void DoublyLinkedList_Adding100000()
        {
            var dlList = new DoublyLinkedList<int>();
            Watch.Restart();
            for (int i = 0; i < 100000; i++) { dlList.Add(i); }
            Watch.Stop();
            Console.WriteLine(Watch.ToString());
        }

        [TestMethod]
        public void DoublyLinkedList_D_WarmUp()
        {
            var dlList = new DoublyLinkedList<int>();
            for (int i = 0; i < 10; i++) { dlList.Add(i); }
            Watch.Restart();
            for (int i = 0; i < 10; i++) { dlList.Remove(element: i); }
            Watch.Stop();
            Console.WriteLine(Watch.ToString());
        }

        [TestMethod]
        public void DoublyLinkedList_Deleting10()
        {
            var dlList = new DoublyLinkedList<int>();
            for (int i = 0; i < 10; i++) { dlList.Add(i); }
            Watch.Restart();
            for (int i = 0; i < 10; i++) { dlList.Remove(element: i); }
            Watch.Stop();
            Console.WriteLine(Watch.ToString());
        }

        [TestMethod]
        public void DoublyLinkedList_Deleting100()
        {
            var dlList = new DoublyLinkedList<int>();
            for (int i = 0; i < 100; i++) { dlList.Add(i); }
            Watch.Restart();
            for (int i = 0; i < 100; i++) { dlList.Remove(element: i); }
            Watch.Stop();
            Console.WriteLine(Watch.ToString());
        }

        [TestMethod]
        public void DoublyLinkedList_Deleting1000()
        {
            var dlList = new DoublyLinkedList<int>();
            for (int i = 0; i < 1000; i++) { dlList.Add(i); }
            Watch.Restart();
            for (int i = 0; i < 1000; i++) { dlList.Remove(element: i); }
            Watch.Stop();
            Console.WriteLine(Watch.ToString());
        }

        [TestMethod]
        public void DoublyLinkedList_Deleting10000()
        {
            var dlList = new DoublyLinkedList<int>();
            for (int i = 0; i < 10000; i++) { dlList.Add(i); }
            Watch.Restart();
            for (int i = 0; i < 10000; i++) { dlList.Remove(element: i); }
            Watch.Stop();
            Console.WriteLine(Watch.ToString());
        }

        [TestMethod]
        public void DoublyLinkedList_Deleting100000()
        {
            var dlList = new DoublyLinkedList<int>();
            for (int i = 0; i < 100000; i++) { dlList.Add(i); }
            Watch.Restart();
            for (int i = 0; i < 100000; i++) { dlList.Remove(element: i); }
            Watch.Stop();
            Console.WriteLine(Watch.ToString());
        }
        #endregion

        #region DynamicArray
        [TestMethod]
        public void DynamicArray_A_WarmUp()
        {
            var dArray = new DynamicArray<int>();
            Watch.Restart();
            for (int i = 0; i < 10; i++) { dArray.Add(i); }
            Watch.Stop();
            Console.WriteLine(Watch.ToString());
        }

        [TestMethod]
        public void DynamicArray_Adding10()
        {
            var dArray = new DynamicArray<int>();
            Watch.Restart();
            for (int i = 0; i < 10; i++) { dArray.Add(i); }
            Watch.Stop();
            Console.WriteLine(Watch.ToString());
        }

        [TestMethod]
        public void DynamicArray_Adding100()
        {
            var dArray = new DynamicArray<int>();
            Watch.Restart();
            for (int i = 0; i < 100; i++) { dArray.Add(i); }
            Watch.Stop();
            Console.WriteLine(Watch.ToString());
        }

        [TestMethod]
        public void DynamicArray_Adding1000()
        {
            var dArray = new DynamicArray<int>();
            Watch.Restart();
            for (int i = 0; i < 1000; i++) { dArray.Add(i); }
            Watch.Stop();
            Console.WriteLine(Watch.ToString());
        }

        [TestMethod]
        public void DynamicArray_Adding10000()
        {
            var dArray = new DynamicArray<int>();
            Watch.Restart();
            for (int i = 0; i < 10000; i++) { dArray.Add(i); }
            Watch.Stop();
            Console.WriteLine(Watch.ToString());
        }

        [TestMethod]
        public void DynamicArray_Adding100000()
        {
            var dArray = new DynamicArray<int>();
            Watch.Restart();
            for (int i = 0; i < 100000; i++) { dArray.Add(i); }
            Watch.Stop();
            Console.WriteLine(Watch.ToString());
        }

        [TestMethod]
        public void DynamicArray_D_WarmUp()
        {
            var dArray = new DynamicArray<int>();
            for (int i = 0; i < 10; i++) { dArray.Add(i); }
            Watch.Restart();
            for (int i = 0; i < 10; i++) { dArray.Remove(element: i); }
            Watch.Stop();
            Console.WriteLine(Watch.ToString());
        }

        [TestMethod]
        public void DynamicArray_Deleting10()
        {
            var dArray = new DynamicArray<int>();
            for (int i = 0; i < 10; i++) { dArray.Add(i); }
            Watch.Restart();
            for (int i = 0; i < 10; i++) { dArray.Remove(element: i); }
            Watch.Stop();
            Console.WriteLine(Watch.ToString());
        }

        [TestMethod]
        public void DynamicArray_Deleting100()
        {
            var dArray = new DynamicArray<int>();
            for (int i = 0; i < 100; i++) { dArray.Add(i); }
            Watch.Restart();
            for (int i = 0; i < 100; i++) { dArray.Remove(element: i); }
            Watch.Stop();
            Console.WriteLine(Watch.ToString());
        }

        [TestMethod]
        public void DynamicArray_Deleting1000()
        {
            var dArray = new DynamicArray<int>();
            for (int i = 0; i < 1000; i++) { dArray.Add(i); }
            Watch.Restart();
            for (int i = 0; i < 1000; i++) { dArray.Remove(element: i); }
            Watch.Stop();
            Console.WriteLine(Watch.ToString());
        }

        [TestMethod]
        public void DynamicArray_Deleting10000()
        {
            var dArray = new DynamicArray<int>();
            for (int i = 0; i < 10000; i++) { dArray.Add(i); }
            Watch.Restart();
            for (int i = 0; i < 10000; i++) { dArray.Remove(element: i); }
            Watch.Stop();
            Console.WriteLine(Watch.ToString());
        }

        [TestMethod]
        public void DynamicArray_Deleting100000()
        {
            var dArray = new DynamicArray<int>();
            for (int i = 0; i < 100000; i++) { dArray.Add(i); }
            Watch.Restart();
            for (int i = 0; i < 100000; i++) { dArray.Remove(element: i); }
            Watch.Stop();
            Console.WriteLine(Watch.ToString());
        }
        #endregion

        #region PriorityQueue
        [TestMethod]
        public void PriorityQueue_A_WarmUp()
        {
            var pQueue = new ADP.DataStructures.PQueue.PriorityQueue<int>();
            Watch.Restart();
            for (int i = 0; i < 10; i++) { pQueue.Add(i); }
            Watch.Stop();
            Console.WriteLine(Watch.ToString());
        }

        [TestMethod]
        public void PriorityQueue_Adding10()
        {
            var pQueue = new ADP.DataStructures.PQueue.PriorityQueue<int>();
            Watch.Restart();
            for (int i = 0; i < 10; i++) { pQueue.Add(i); }
            Watch.Stop();
            Console.WriteLine(Watch.ToString());
        }

        [TestMethod]
        public void PriorityQueue_Adding100()
        {
            var pQueue = new ADP.DataStructures.PQueue.PriorityQueue<int>();
            Watch.Restart();
            for (int i = 0; i < 100; i++) { pQueue.Add(i); }
            Watch.Stop();
            Console.WriteLine(Watch.ToString());
        }

        [TestMethod]
        public void PriorityQueue_Adding1000()
        {
            var pQueue = new ADP.DataStructures.PQueue.PriorityQueue<int>();
            Watch.Restart();
            for (int i = 0; i < 1000; i++) { pQueue.Add(i); }
            Watch.Stop();
            Console.WriteLine(Watch.ToString());
        }

        [TestMethod]
        public void PriorityQueue_Adding10000()
        {
            var pQueue = new ADP.DataStructures.PQueue.PriorityQueue<int>();
            Watch.Restart();
            for (int i = 0; i < 10000; i++) { pQueue.Add(i); }
            Watch.Stop();
            Console.WriteLine(Watch.ToString());
        }

        [TestMethod]
        public void PriorityQueue_Adding100000()
        {
            var pQueue = new ADP.DataStructures.PQueue.PriorityQueue<int>();
            Watch.Restart();
            for (int i = 0; i < 100000; i++) { pQueue.Add(i); }
            Watch.Stop();
            Console.WriteLine(Watch.ToString());
        }

        [TestMethod]
        public void PriorityQueue_D_WarmUp()
        {
            var pQueue = new ADP.DataStructures.PQueue.PriorityQueue<int>();
            for (int i = 0; i < 10; i++) { pQueue.Add(i); }
            Watch.Restart();
            for (int i = 0; i < 10; i++) { pQueue.Poll(); }
            Watch.Stop();
            Console.WriteLine(Watch.ToString());
        }

        [TestMethod]
        public void PriorityQueue_Deleting10()
        {
            var pQueue = new ADP.DataStructures.PQueue.PriorityQueue<int>();
            for (int i = 0; i < 10; i++) { pQueue.Add(i); }
            Watch.Restart();
            for (int i = 0; i < 10; i++) { pQueue.Poll(); }
            Watch.Stop();
            Console.WriteLine(Watch.ToString());
        }

        [TestMethod]
        public void PriorityQueue_Deleting100()
        {
            var pQueue = new ADP.DataStructures.PQueue.PriorityQueue<int>();
            for (int i = 0; i < 100; i++) { pQueue.Add(i); }
            Watch.Restart();
            for (int i = 0; i < 100; i++) { pQueue.Poll(); }
            Watch.Stop();
            Console.WriteLine(Watch.ToString());
        }

        [TestMethod]
        public void PriorityQueue_Deleting1000()
        {
            var pQueue = new ADP.DataStructures.PQueue.PriorityQueue<int>();
            for (int i = 0; i < 1000; i++) { pQueue.Add(i); }
            Watch.Restart();
            for (int i = 0; i < 1000; i++) { pQueue.Poll(); }
            Watch.Stop();
            Console.WriteLine(Watch.ToString());
        }

        [TestMethod]
        public void PriorityQueue_Deleting10000()
        {
            var pQueue = new ADP.DataStructures.PQueue.PriorityQueue<int>();
            for (int i = 0; i < 10000; i++) { pQueue.Add(i); }
            Watch.Restart();
            for (int i = 0; i < 10000; i++) { pQueue.Poll(); }
            Watch.Stop();
            Console.WriteLine(Watch.ToString());
        }

        [TestMethod]
        public void PriorityQueue_Deleting100000()
        {
            var pQueue = new ADP.DataStructures.PQueue.PriorityQueue<int>();
            for (int i = 0; i < 100000; i++) { pQueue.Add(i); }
            Watch.Restart();
            for (int i = 0; i < 100000; i++) { pQueue.Poll(); }
            Watch.Stop();
            Console.WriteLine(Watch.ToString());
        }
        #endregion

        #region Stack
        [TestMethod]
        public void Stack_A_WarmUp()
        {
            var stack = new ADPStack<int>();
            Watch.Restart();
            for (int i = 0; i < 10; i++) { stack.Push(i); }
            Watch.Stop();
            Console.WriteLine(Watch.ToString());
        }

        [TestMethod]
        public void Stack_Adding10()
        {
            var stack = new ADPStack<int>();
            Watch.Restart();
            for (int i = 0; i < 10; i++) { stack.Push(i); }
            Watch.Stop();
            Console.WriteLine(Watch.ToString());
        }

        [TestMethod]
        public void Stack_Adding100()
        {
            var stack = new ADPStack<int>();
            Watch.Restart();
            for (int i = 0; i < 100; i++) { stack.Push(i); }
            Watch.Stop();
            Console.WriteLine(Watch.ToString());
        }

        [TestMethod]
        public void Stack_Adding1000()
        {
            var stack = new ADPStack<int>();
            Watch.Restart();
            for (int i = 0; i < 1000; i++) { stack.Push(i); }
            Watch.Stop();
            Console.WriteLine(Watch.ToString());
        }

        [TestMethod]
        public void Stack_Adding10000()
        {
            var stack = new ADPStack<int>();
            Watch.Restart();
            for (int i = 0; i < 10000; i++) { stack.Push(i); }
            Watch.Stop();
            Console.WriteLine(Watch.ToString());
        }

        [TestMethod]
        public void Stack_Adding100000()
        {
            var stack = new ADPStack<int>();
            Watch.Restart();
            for (int i = 0; i < 100000; i++) { stack.Push(i); }
            Watch.Stop();
            Console.WriteLine(Watch.ToString());
        }

        [TestMethod]
        public void Stack_D_WarmUp()
        {
            var stack = new ADPStack<int>();
            for (int i = 0; i < 10; i++) { stack.Push(i); }
            Watch.Restart();
            for (int i = 0; i < 10; i++) { stack.Pop(); }
            Watch.Stop();
            Console.WriteLine(Watch.ToString());
        }

        [TestMethod]
        public void Stack_Deleting10()
        {
            var stack = new ADPStack<int>();
            for (int i = 0; i < 10; i++) { stack.Push(i); }
            Watch.Restart();
            for (int i = 0; i < 10; i++) { stack.Pop(); }
            Watch.Stop();
            Console.WriteLine(Watch.ToString());
        }

        [TestMethod]
        public void Stack_Deleting100()
        {
            var stack = new ADPStack<int>();
            for (int i = 0; i < 100; i++) { stack.Push(i); }
            Watch.Restart();
            for (int i = 0; i < 100; i++) { stack.Pop(); }
            Watch.Stop();
            Console.WriteLine(Watch.ToString());
        }

        [TestMethod]
        public void Stack_Deleting1000()
        {
            var stack = new ADPStack<int>();
            for (int i = 0; i < 1000; i++) { stack.Push(i); }
            Watch.Restart();
            for (int i = 0; i < 1000; i++) { stack.Pop(); }
            Watch.Stop();
            Console.WriteLine(Watch.ToString());
        }

        [TestMethod]
        public void Stack_Deleting10000()
        {
            var stack = new ADPStack<int>();
            for (int i = 0; i < 10000; i++) { stack.Push(i); }
            Watch.Restart();
            for (int i = 0; i < 10000; i++) { stack.Pop(); }
            Watch.Stop();
            Console.WriteLine(Watch.ToString());
        }

        [TestMethod]
        public void Stack_Deleting100000()
        {
            var stack = new ADPStack<int>();
            for (int i = 0; i < 100000; i++) { stack.Push(i); }
            Watch.Restart();
            for (int i = 0; i < 100000; i++) { stack.Pop(); }
            Watch.Stop();
            Console.WriteLine(Watch.ToString());
        }
        #endregion
    }
}
