using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace UnitTestProject
{
    public class RestrictedPriorityQueue<T>
    {
        public RestrictedPriorityQueue(int n, Comparison<T> comparison)
        {
            this.N = n;
            this.queue = new List<T>(n + 1);
            this.QueueComparisonFunction = comparison;
        }

        private int N;
        private List<T> queue;

        private Comparison<T> QueueComparisonFunction { set; get;}


        /// <summary>
        /// Conditionally adds an item to the priority queue. The queue has a soft-maximum size. If the queue is full of higher priority
        /// items then the new item being added will be discarded. If the queue is 'full' or 'over-full' and the new item has higher priority
        /// then the new item will be placed into the queue at its rightful position and the queue will be truncated to it's 'full' condition. 
        /// i.e. the overfilled items will all be discarded. If the queue is full or 'over-full' and the new item has equal priority to the 
        /// last item in the queue then the new equally-ranked item will be added to the end of the queue. So, the priority queue may grow to be N items 
        /// long, but may grow longer if new items being added are of equal rank to the lowest priority item on the queue.
        /// </summary>
        /// <param name="item">An item of type T to be added to the priority queue.</param>
        public void Add(T item)
        {
            this.queue.Add(item);

            this.queue.Sort(QueueComparisonFunction);

            while (this.queue.Count > this.N && QueueComparisonFunction(this.queue[N], this.queue[N - 1]) != 0)
            {
                this.queue.RemoveAt(this.queue.Count - 1);
            }
        }

        public List<T> Queue
        {
            get
            {
                return this.queue;
            }
        }
    }

}
