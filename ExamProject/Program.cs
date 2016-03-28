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
            list.AddFirst("fourth");
            list.AddFirst("third");
            list.AddFirst("second");
            list.AddFirst("first");
            list.AddLast("last");
            list.AddLast("last again");
            list.AddLast("now really last");
            list.Print();
            list.Find("first");
            Console.WriteLine("--------now delete First-----------");
            list.RemoveFirst();
            list.Print();
            Console.WriteLine("--------now delete Last-----------");
            list.RemoveLast();
            list.Print();
            Console.WriteLine("--------now delete with value (second)-----------");
            list.Remove("second");
           
            Console.ReadKey();
        }
    }
}
