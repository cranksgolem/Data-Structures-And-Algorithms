using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDoublyLinkedList
{
    public class Node<T>
    {
        public T Data { get; private set; }
        public Node<T> Next { get; set; }
        public Node<T> Prev { get; set; }
 
        public Node(T data)
        {
            Data = data;
        }
    }
}
