using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace priorityqueue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var pq = new PriorityQueue<string>();
            
            pq.Enqueue("four", 4);
            pq.Enqueue("ten", 10);
            pq.Enqueue("three", 3);
            pq.Enqueue("five", 5);
            pq.Enqueue("six", 6);
            pq.Enqueue("eighteen", 18);
            pq.Enqueue("one", 1);
            pq.Enqueue("seventy", 70);
            pq.Enqueue("two", 2);
            

            while (pq.Count > 0)
            {
                Console.WriteLine(pq.Dequeue());
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
