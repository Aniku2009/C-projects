using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Array
{
     public class  InputData
    {
        public int InputNumber ()
       {
            int number=0;
            while (!Int32.TryParse(Console.ReadLine(), out number))
            {
                Console.WriteLine("Wrong data type! Try again");
            }
           return number;
       }
    }          
             
       class program
     {
        static void Main(string[] args)
        {
            InputData myInputData = new InputData();
            Console.WriteLine("Please enter array size");
            int ArraySize = myInputData.InputNumber();
            int i;
            int[] Array = new int[ArraySize];    
            for (i=0; i < Array.Length; i++)  
            {
             Console.WriteLine("Please enter {0} value and press ENTER", i+1);
                int ArrayValue = myInputData.InputNumber();
                Array[i] = ArrayValue;
            }
            Console.WriteLine("Maximum value {0}", Array.Max());
            Console.WriteLine("Minimum value {0}", Array.Min());
            Console.ReadKey();
       }


     }
}

