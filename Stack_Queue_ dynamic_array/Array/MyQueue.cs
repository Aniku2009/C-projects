using System;


namespace Stack_Queue_Dynamic
{
    class MyQueue<T> : Buffer<T>, IMyQueue<T>
    {

        public MyQueue()
        { }

        public override T Pop()
        {
            if (!IsEmpty())
            {
                T item = array[0];
                for (int i = 0; i < size - 1; i++)
                {
                    array[i] = array[i + 1];
                }
                Console.WriteLine("Pop element:{0}", item);
                size --;
                
                decimal d=Capacity/Size;
                if (d == 2)
                {
                    ReduceArray();
                }

                return item;
            }
            else
            {
                Console.WriteLine("Queue is empty!");
                return default(T);
            }
        }
     
    }
}
