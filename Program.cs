using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Queue
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Stack follows FILO
            Console.WriteLine("----------Stack----------");
            //declared a stack
            Stack<string> stack = new Stack<string>();
            //pushed/Added 3 data in stack
            stack.Push("First In");
            stack.Push("Second In");
            stack.Push("Third In");
            Console.WriteLine("After adding 3 data in stack");
            //result after adding data
            Console.WriteLine(stack.Peek());
            //deleting/Poping single data from stack 
            //deleted element will be the element which added last(Third In)
            stack.Pop();
            Console.WriteLine("After poping 1 data in stack");
            //Result after deleting/Poping single data 
            Console.WriteLine(stack.Peek());
            Console.ReadLine();

            //Queue follows FIFO
            Console.WriteLine("----------Queue----------");
            //Declared a Queue
            Queue<string> queue = new Queue<string>();  
            //Endueue/Added 3 records in Queue
            queue.Enqueue("First data In");
            queue.Enqueue("Second data In");
            queue.Enqueue("Third data In");
            Console.WriteLine("After adding 3 data in Queue");
            //result after adding/Enqueue data
            Console.WriteLine(queue.Peek());
            Console.WriteLine("After poping 1 data in Queue");
            //deleting/Poping single record from Queue
            //deleted element will be the element which added first(First data In)
            queue.Dequeue();
            //Result after deleting/dequeueing single Record 
            Console.WriteLine(queue.Peek());
            Console.ReadLine();
        }
    }
}
