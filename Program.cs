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
            Stacks_Methods<int> stacksQueuesMethods = new Stacks_Methods<int>();
            stacksQueuesMethods.Push(70);
            stacksQueuesMethods.Push(30);
            stacksQueuesMethods.Push(56);
            //Verifying elements are added in stack or not !
            stacksQueuesMethods.DisplayInStacks();
            


        }
    }
}