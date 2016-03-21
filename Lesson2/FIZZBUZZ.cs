using System;



namespace Divider
{
    class Program
    {
        static void Main()
        {
            int y;
            int i;
            int z;
            for (i = 1; i <= 100; i++)
            {

                z = i % 3;
                y = i % 5;

                if (y == 0 && z == 0)
                {
                    Console.WriteLine("FIZZBUZZ");
                }

                else if (y == 0)
                {
                    Console.WriteLine("BUZZ");

                }
                else if (z == 0)
                {
                    Console.WriteLine("FIZZ");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("Press any key");
            Console.ReadKey();
           }                          
           
     }
}



