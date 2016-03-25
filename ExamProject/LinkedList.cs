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
        public void AddFirst(T value)  // add node to the first place;
        {
            if (node == null)
            {
                node = new Node<T>(null, value, null);
                size++;
            }
            else
            {
                Node<T> temp = new Node<T>(null, value, node);
                node.prevNode = temp;
                size++;
            }
        }
        public void AddLast(T value)  // add node to the last place;
        {
            if (node == null)
            {
                return;
            }
            else
            {
                Node<T> temp = new Node<T>(node, value, null);
                node.prevNode = temp;
                size++;
            }

        }


        public void Remove(T value)
        {
            while (true)
            {
                if (node.nodeData.Equals(value))
                {
                    break;
                }
                else 
                {
                    Console.WriteLine("Nothig to delete");
                }
                node = node.prevNode;
            }

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
                T tempnext = node.nextNode.prevNode.nodeData;
                T tempprev = node.prevNode.nextNode.nodeData;

                node = node.nextNode.prevNode;
                node.nodeData =tempnext;

                node = node.prevNode.nextNode;
                node.nodeData = tempprev;
            }


        }




        public void RemoveFirst()
        {
            while (true)
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
            while (true)
            {
                if (node == null)
                {
                    break;
                }
                else if (node.nextNode == null)
                {
                    node.nextNode.prevNode = null;
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
            node = Last();
            if (node == null)
            {

                return false;
            }
            else
            {
                while (true)
                {
                    if (node.nodeData.Equals(value))
                    {
                        return true;
                    }
                    else if (node.prevNode == null)
                    {
                        return false;
                    }
                    else
                    {
                        node = node.prevNode;
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
              int i;
              for (i = 1; i <= size; i++)
                  Console.WriteLine("{0}", node.nodeData);
                   node = node.nextNode;
               
             }
           
         }
    }
}
