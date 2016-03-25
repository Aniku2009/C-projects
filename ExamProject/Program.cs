using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProject
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<string> list = new LinkedList<string>();
            list.AddFirst("first");
           // list.AddFirst("second");
            //list.AddFirst("third");
            //list.AddFirst("first");
            list.AddLast("last");
            //// list.AddLast("last");
            //list.AddLast("last");
            list.Print();
           // list.RemoveFirst();
            //list.Remove("second");
            Console.ReadKey();
        }
    }
}
