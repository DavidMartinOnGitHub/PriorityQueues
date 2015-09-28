using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject
{
        [TestClass]
        public class UnitTestRestrictedPriorityQueue
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
                RestrictedPriorityQueue<int> q = new RestrictedPriorityQueue<int>(5, new System.Comparison<int>(MyComparisonMethod));
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
                RestrictedPriorityQueue<int> q = new RestrictedPriorityQueue<int>(3, new System.Comparison<int>(MyComparisonMethod));
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
                RestrictedPriorityQueue<int> q = new RestrictedPriorityQueue<int>(3, new System.Comparison<int>(MyComparisonMethod));
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
                RestrictedPriorityQueue<int> q = new RestrictedPriorityQueue<int>(3, new System.Comparison<int>(MyComparisonMethod));
                q.Add(7);
                q.Add(4);
                q.Add(1);
                q.Add(2);
                q.Add(3);
                q.Add(5);
                q.Add(6);

                CollectionAssert.AreEqual(new int[] { 7, 6, 5 }, q.Queue);

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
                RestrictedPriorityQueue<int> q = new RestrictedPriorityQueue<int>(5, new System.Comparison<int>(AscendingOrderComparisonMethod));
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
                RestrictedPriorityQueue<int> q = new RestrictedPriorityQueue<int>(3, new System.Comparison<int>(AscendingOrderComparisonMethod));
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
                RestrictedPriorityQueue<int> q = new RestrictedPriorityQueue<int>(3, new System.Comparison<int>(AscendingOrderComparisonMethod));
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
                RestrictedPriorityQueue<int> q = new RestrictedPriorityQueue<int>(3, new System.Comparison<int>(AscendingOrderComparisonMethod));
                q.Add(7);
                q.Add(4);
                q.Add(1);
                q.Add(2);
                q.Add(3);
                q.Add(5);
                q.Add(6);

                CollectionAssert.AreEqual(new int[] { 1, 2, 3 }, q.Queue);

            }

            private static int DescendingOrderComparisonMethod(int x, int y)
            {
                if (x > y) return -1;
                else if (x < y) return +1;
                else return 0;
            }

            [TestMethod]
            public void TestMethod9()
            {
                RestrictedPriorityQueue<int> q = new RestrictedPriorityQueue<int>(3, new System.Comparison<int>(DescendingOrderComparisonMethod));

                q.Add(6);
                q.Add(5);
                q.Add(4);
                CollectionAssert.AreEqual(new int[] { 6, 5, 4 }, q.Queue, "Basic queue. ");

                q.Add(4);
                q.Add(4);
                q.Add(4);
                CollectionAssert.AreEqual(new int[] { 6, 5, 4, 4, 4, 4 }, q.Queue, "Queue extending. ");


                q.Add(7);
                CollectionAssert.AreEqual(new int[] { 7, 6, 5 }, q.Queue, "Queue got chopped. ");

            }


            [TestMethod]
            public void TestMethod10()
            {
                RestrictedPriorityQueue<int> q = new RestrictedPriorityQueue<int>(3, new System.Comparison<int>(DescendingOrderComparisonMethod));

                q.Add(7);
                q.Add(6);
                q.Add(4);
                CollectionAssert.AreEqual(new int[] { 7, 6, 4 }, q.Queue, "Basic queue. ");

                q.Add(4);
                q.Add(4);
                q.Add(4);
                CollectionAssert.AreEqual(new int[] { 7, 6, 4, 4, 4, 4 }, q.Queue, "Queue extending. ");


                q.Add(5);
                CollectionAssert.AreEqual(new int[] { 7, 6, 5 }, q.Queue, "Queue got chopped. ");

            }

        }
    
}
