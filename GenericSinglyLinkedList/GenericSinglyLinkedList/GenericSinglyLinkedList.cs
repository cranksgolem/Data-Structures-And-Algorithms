using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericSinglyLinkedList
{
    public class GenericSinglyLinkedList<T>
    {
        private Node<T> _head;
        private Node<T> _tail;

        public Node<T> Head
        {
            get { return _head; }
            set { _head = value; }
        }

        public Node<T> Tail
        {
            get { return _tail; }
            set { _tail = value; }
        }


    }
}
