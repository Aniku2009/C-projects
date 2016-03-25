using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExamProject
{
    public class Node<T>
    {
        public Node<T> prevNode;  // link to the previous node;
        public T nodeData;   // data in node;
        public Node<T> nextNode;  // link to the next node;       

        public Node(Node<T> prevNode, T nodeData, Node<T> nextNode)  // constructor of data in node;
        {
            this.prevNode = prevNode;
            this.nodeData = nodeData;
            this.nextNode = nextNode;

        }
    }
}
