using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList
{
    public class Node
    {
        public int Data { get; set; }
        public Node Next { get; set; }
        public Node Prev { get; set; }

        public Node()
        {

        }

        public Node(int data)
        {
            Data = data;
        }

        public Node(int data, Node next)
        {
            Data = data;
            Next = next;
        }
    }
}
