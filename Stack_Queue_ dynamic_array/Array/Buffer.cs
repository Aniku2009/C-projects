using System;


namespace Stack_Queue_Dynamic
{
    abstract class Buffer<T> : IPrintable
    {
        protected int size;
        protected T[] array;
        public abstract T Pop();
       
        
        public Buffer()
        {
            array = new T[1];
        }



        public int Capacity
        {
            get { return array.Length; }
        }

        public int Size
        {
            get { return size; }
            private set { size = value; }
        }

     
        public void Push(T value)
        {
            {
                if (Size >= Capacity)
                {
                    ResizeArray();
                }
                array[Size] = value;
                Size++;
            }
           
        }

       
        public bool IsEmpty()
        {
           
            if (size == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
       
        public void Print()
        {
            if (!IsEmpty())
            {
                Console.WriteLine("Content:");  
                for (int i = 0; i < size; i++)
                {
                    Console.Write(" |{0}| \n", array[i]);
                }
            }
            else
            {
                Console.WriteLine("Is empty!");
            }
        }

       
        private void ResizeArray()
        {
            T[] resizedArray = new T[Capacity * 2];
            for (int i = 0; i < Size; i++)
            {
                resizedArray[i] = array[i];
            }
            array = resizedArray;
        }

        
        public void ReduceArray()
        {
            T[] resizedArray = new T[Capacity / 2];
            for (int i = 0; i < Size; i++)
            {
                resizedArray[i] = array[i];
            }
            array = resizedArray;
        }
       
    }
}
