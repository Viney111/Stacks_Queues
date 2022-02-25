using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Stacks_Queues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            QueuesMethods<int> queuesMethods = new QueuesMethods<int>();
            queuesMethods.Enqueue(56);
            queuesMethods.Enqueue(30);
            queuesMethods.Enqueue(70);
            //Displaying the queue;
            queuesMethods.DisplayQueue();

        }
    }
}