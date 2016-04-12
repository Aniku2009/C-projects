using System;


namespace Stack_Queue_Dynamic
{
    class MyStack<T> : Buffer<T>, IMyStack<T>
    {
        public MyStack()
        { }

        public override T Pop()
        {
            if (!IsEmpty())
            {
                Console.WriteLine("Pop element:{0}", array[size - 1]); 
                return array[--size];
                
                decimal d = Capacity / Size;
                if (d == 2)
                {
                    ReduceArray();
                }
            }
            else
            {
                Console.WriteLine("Stack is empty!");
                return default(T);
            }
        }
      
    }
}
