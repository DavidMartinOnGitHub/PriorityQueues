using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

#if MSTEST
using Microsoft.VisualStudio.TestTools.UnitTesting;
#endif

namespace UnitTestProject
{
    public class FixedLengthPriorityQueue<T>
    {
        /// <summary>
        /// Constructor for the Fixed-Length priority queue.
        /// </summary>
        /// <param name="n">The maximum length of the queue.</param>
        /// <param name="comparison">A Comparision function used to determine the relative priority of an item.</param>
        public FixedLengthPriorityQueue(int n, Comparison<T> comparison)
        {
            this.N = n;
            this.queue = new List<T>(n + 1);
            this.QueueComparisonFunction = comparison;
        }

        private int N;
        private List<T> queue;

        private Comparison<T> QueueComparisonFunction { set; get;}

        public void Add(T item)
        {
            // if the queue is full and the new item does not have higher priority than the last item then return now.            
            if(this.queue.Count == this.N && QueueComparisonFunction(this.queue[this.queue.Count - 1], item) < 0) return;

            // add the item to the priority queue, sort the queue and remove the least priority item
            this.queue.Add(item);
            this.queue.Sort(QueueComparisonFunction);           
            if (this.queue.Count > this.N) this.queue.RemoveAt(this.queue.Count - 1);
        }

        /// <summary>
        /// Get the priority queue in order. 
        /// </summary>
        public List<T> Queue
        {
            get
            {
                return this.queue;
            }
        }
    }


}
