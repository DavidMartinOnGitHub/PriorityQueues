using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTestFixedLengthPriorityQueue
    {
        // sorts by int in descending order
        private static int MyComparisonMethod(int x, int y)
        {
            if (x > y) return -1;
            else if (x < y) return +1;
            else return 0;
        }

        [TestMethod]
        public void TestMethod1()
        {
            FixedLengthPriorityQueue<int> q = new FixedLengthPriorityQueue<int>(5, new System.Comparison<int>(MyComparisonMethod));
            q.Add(7);
            q.Add(1);
            q.Add(2);
            q.Add(3);
            q.Add(4);
            q.Add(5);
            q.Add(6);

            CollectionAssert.AreEqual(new int[] { 7, 6, 5, 4, 3 }, q.Queue);

        }
        [TestMethod]
        public void TestMethod2()
        {
            FixedLengthPriorityQueue<int> q = new FixedLengthPriorityQueue<int>(3, new System.Comparison<int>(MyComparisonMethod));
            q.Add(1);
            q.Add(2);
            q.Add(3);
            q.Add(4);
            q.Add(5);
            q.Add(6);

            CollectionAssert.AreEqual(new int[] { 6, 5, 4 }, q.Queue);

        }
        [TestMethod]
        public void TestMethod3()
        {
            FixedLengthPriorityQueue<int> q = new FixedLengthPriorityQueue<int>(3, new System.Comparison<int>(MyComparisonMethod));
            q.Add(7);
            q.Add(6);
            q.Add(5);
            q.Add(4);
            q.Add(3);
            q.Add(2);
            q.Add(1);

            CollectionAssert.AreEqual(new int[] { 7, 6, 5 }, q.Queue);

        }
        [TestMethod]
        public void TestMethod4()
        {
            FixedLengthPriorityQueue<int> q = new FixedLengthPriorityQueue<int>(3, new System.Comparison<int>(MyComparisonMethod));
            q.Add(7);
            q.Add(4);
            q.Add(1);
            q.Add(2);
            q.Add(3);
            q.Add(5);
            q.Add(6);

            CollectionAssert.AreEqual(new int[] { 7, 6, 5 }, q.Queue);

        }

        // sorts with Item2 in descending order
        private static int MyTupleComparison(Tuple<int, int> x, Tuple<int, int> y)
        {
            if (x.Item2 > y.Item2) return -1;
            else if (x.Item2 < y.Item2) return +1;
            else return 0;
        }

        [TestMethod]
        public void TestFixedLengthPriorityQueueWithMyTupleComparison()
        {
            FixedLengthPriorityQueue<Tuple<int, int>> q = new FixedLengthPriorityQueue<Tuple<int, int>>(3, new System.Comparison<Tuple<int, int>>(MyTupleComparison));
            q.Add(new Tuple<int, int>(0, 5));
            q.Add(new Tuple<int, int>(1, 3));
            q.Add(new Tuple<int, int>(2, 6));
            q.Add(new Tuple<int, int>(5, 9));
            q.Add(new Tuple<int, int>(3, 1));

            CollectionAssert.AreEqual(new Tuple<int, int>[] { new Tuple<int, int>(5, 9), new Tuple<int, int>(2, 6), new Tuple<int, int>(0, 5) }, q.Queue);

        }

        private static int AscendingOrderComparisonMethod(int x, int y)
        {
            if (x > y) return +1;
            else if (x < y) return -1;
            else return 0;
        }

        [TestMethod]
        public void TestMethod5()
        {
            FixedLengthPriorityQueue<int> q = new FixedLengthPriorityQueue<int>(5, new System.Comparison<int>(AscendingOrderComparisonMethod));
            q.Add(7);
            q.Add(1);
            q.Add(2);
            q.Add(3);
            q.Add(4);
            q.Add(5);
            q.Add(6);

            CollectionAssert.AreEqual(new int[] { 1, 2, 3, 4, 5 }, q.Queue);

        }
        [TestMethod]
        public void TestMethod6()
        {
            FixedLengthPriorityQueue<int> q = new FixedLengthPriorityQueue<int>(3, new System.Comparison<int>(AscendingOrderComparisonMethod));
            q.Add(1);
            q.Add(2);
            q.Add(3);
            q.Add(4);
            q.Add(5);
            q.Add(6);

            CollectionAssert.AreEqual(new int[] { 1, 2, 3 }, q.Queue);

        }
        [TestMethod]
        public void TestMethod7()
        {
            FixedLengthPriorityQueue<int> q = new FixedLengthPriorityQueue<int>(3, new System.Comparison<int>(AscendingOrderComparisonMethod));
            q.Add(7);
            q.Add(6);
            q.Add(5);
            q.Add(4);
            q.Add(3);
            q.Add(2);
            q.Add(1);

            CollectionAssert.AreEqual(new int[] { 1, 2, 3 }, q.Queue);

        }
        [TestMethod]
        public void TestMethod8()
        {
            FixedLengthPriorityQueue<int> q = new FixedLengthPriorityQueue<int>(3, new System.Comparison<int>(AscendingOrderComparisonMethod));
            q.Add(7);
            q.Add(4);
            q.Add(1);
            q.Add(2);
            q.Add(3);
            q.Add(5);
            q.Add(6);

            CollectionAssert.AreEqual(new int[] { 1, 2, 3 }, q.Queue);

        }
    }
}
