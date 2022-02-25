using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stacks_Queues
{
    internal class Stacks_Methods<T>
    {
        public Node<T> top;
        //For pushiing elements in Stack.(LIFO)
        public void Push(T data)
        {
            Node<T> newNode = new Node<T>(data);
            if (top == null)
            {
                newNode.next = null;
                Console.WriteLine($"{newNode.data} has been pushed in empty stack.");
            }
            else
            {
                newNode.next = top;
                Console.WriteLine($"{newNode.data} has been pushed");
            }
            top = newNode;
        }

        //For display element in stacks
        public void DisplayInStacks()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is empty");
            }
            else
            {
                Node<T> temp = top;
                while (temp != null)
                {
                    Console.WriteLine(temp.data);
                    temp = temp.next;
                }
            }
        }
    }
}
