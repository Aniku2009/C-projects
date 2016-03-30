using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProject
{

    class LinkedList<T> : ILinkedList<T>
    {
        Node<T> node = null;
        int size = 0;


        public void AddFirst(T value)  
        {
            size++;
            if (node == null)
            {
                node = new Node<T>(null, value, null);
            }
            else
            {
                Node<T> temp = new Node<T>(null, value, First());
                First().prevNode = temp;
            }
        }


        public void AddLast(T value)  
        {
            size++;
            if (node == null)
            {
                node = new Node<T>(null, value, null);
            }
            else
            {
                Node<T> temp = new Node<T>(Last(), value, null);
                Last().nextNode = temp;
            }
        }


        public void Remove(T value)
        {
            node = First();
            if (node == null)
            {
                Console.WriteLine("Nothing to delete");
            }
            else
            {
                while (node.nextNode != null)
                {
                    if (node.nodeData.Equals(value))
                    {
                        if (node.prevNode == null)
                        {
                            RemoveFirst();
                        }
                        else if (node.nextNode == null)
                        {
                            RemoveLast();
                        }
                        else
                        {
                            Node<T> temp = node.nextNode;
                            node.nextNode.prevNode = node.prevNode;
                            node.prevNode.nextNode = node.nextNode;
                            node.prevNode.nextNode = temp;
                            size--;
                            break;
                        }
                    }
                    else /*if (node.nextNode == null)*/
                    {
                        //break;
                        node = node.nextNode;
                    }
                    //else
                    //{
                    //    node = node.nextNode;
                    //}
                }
            }
        }




        public void RemoveFirst()
        {
            //while (node.prevNode == null)
            Node<T> tempPrint = node;
                int i; 
            for (i = 1; i <= size; i++)
              {
               
                if (node == null)
                {
                    break;
                }
                else if (node.prevNode == null)
                {
                    node.nextNode.prevNode = null;
                    node = node.nextNode;
                    size--;
                    break;
                }
                else
                {
                    node = node.prevNode;
                }
            }
        }
 
        public void RemoveLast()

        {
           // while (node.nextNode != null)
             Node<T> tempPrint = node;
                int i; 
            for (i = 1; i <= size; i++)
            {
                if (node == null)
                {
                    break;
                }
                else if (node.nextNode == null)
                {
                    node.prevNode.nextNode = null;
                    node = node.prevNode;
                    size--;
                    break;
                }
                else
                {
                    node = node.nextNode;
                }
            }
        }
        
       
        public bool Find(T value)
        {
            node = First();
            
            if (node == null)
            {

                Console.WriteLine("----Can't find the value because list is empty----");
                return false;
            }
            else
            {
                while (true)
                {
                    if (node.nodeData.Equals(value))
                    {
                        Console.WriteLine("----Looked value exists in the list----");
                        return true;
                    }
                    else if (node.prevNode == null)
                    {
                        Console.WriteLine("----Looked value doesn't exist in the list----");
                        return false;
                    }
                    else
                    {
                        node = node.nextNode;
                    }
                
                }
            }
        }
        public int Lenght()
        {
            return size;
        }

       public  Node<T> First()
        {
           
            while (true)
            {
                if (node == null)
                {
                    return null;
                }
                else if (node.prevNode == null)
                {
                    return node;
                }
                else
                {
                    node = node.prevNode;
                }
            }
        }
        public Node<T> Last()
        {
            while (true)
            {
                if (node == null)
                {
                    return null;
                }
                else if (node.nextNode == null)
                {
                    return node;
                }
                else
                {
                    node = node.nextNode;
                }
            }
        }

        public void Print()
        {
                 
           
            if (First() == null)
            {
                Console.WriteLine("List is empty");
            }        
            else
            {
                Node<T> tempPrint = node;
                int i;
                for (i = 1; i <= size; i++)
              {
                  Console.WriteLine("{0}", tempPrint.nodeData);
                 tempPrint = tempPrint.nextNode;
              }
             }
           
         }
    }
}
