using System;




namespace Divider
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число А");
            var ValueA = Console.ReadLine();
            var A = Single.Parse(ValueA);

            Console.WriteLine("Введите число B");
            var ValueB = Console.ReadLine();
            var B = Single.Parse(ValueB);

            var Z = A % B;

            if  (Z == 0)
            {
                Console.WriteLine("{1} является делителем числа {0}", A, B);
                Console.WriteLine("Нажмите любую клавишу");
                Console.ReadKey();
           }
            else
            {
                Console.WriteLine("{1} не является делителем числа {0}", A, B);
                Console.WriteLine("Нажмите любую клавишу");
                Console.ReadKey();
            }
        }
    }
}
