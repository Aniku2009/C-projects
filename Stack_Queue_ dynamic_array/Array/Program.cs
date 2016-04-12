using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Stack_Queue_Dynamic
{
    class Program
    {
        static void Main(string[] args)
        {
          
             
            Console.WriteLine("-----------Stack-----------");
            MyStack<string> Stack = new MyStack<string>();
            Stack.Push("STECK1");
            Stack.Push("STECK2");
            Stack.Push("STECK3");
            Stack.Push("STECK4");
            Stack.Push("STECK5");
            Stack.Print();
            Stack.Pop();
            Stack.Pop();
            Stack.Print();
            Console.WriteLine();

              
            Console.WriteLine("-----------Queue-----------");
            MyQueue<int> Queue = new MyQueue<int>();
            Queue.Push(1);
            Queue.Push(2);
            Queue.Push(3);
            Queue.Push(4);
            Queue.Push(5);
            Queue.Print();
            Queue.Pop();
            Queue.Pop();
            Queue.Print();
            Console.ReadKey();
        }
    }
}
