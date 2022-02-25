using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks_Queues
{
    internal class QueuesMethods <T>
    {
        public Node<T> top;
        //For Adding elements in queue.FIFO
        public void Enqueue(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (top == null)
            {
                top = newNode;
                Console.WriteLine($"{newNode.data} has been added to queue.");
            }
            else
            {
                Node<T> temp = top;
                while(temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
                Console.WriteLine($"{newNode.data} has been added to queue.");
            }
        }
        //For displaying the elements in queue.
        public void DisplayQueue()
        {
            if (top == null)
            {
                Console.WriteLine("Queue is empty");
            }
            else
            {
                Node<T> temp = top;
                while(temp != null)
                {
                    Console.WriteLine($"{temp.data}");
                    temp = temp.next;
                }
            }
        }
    }
}
