using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDoublyLinkedList
{
    public class GenericDoublyLinkedList<T>
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

        public void AddToHead(Node<T> node)
        {
            if (Head != null)
                Head.Prev = node;

            node.Next = Head;
            Head = node;

            if (Tail == null)
            {
                Tail = Head;
            }
        }

        public void AddToTail(Node<T> node)
        {
            if (Tail != null)
                Tail.Next = node;

            node.Prev = Tail;
            Tail = node;

            if (Head == null)
            {
                Head = Tail;
            }
        }

        public T DeleteFromHead()
        {
            var element = Head.Data;
            if (Head.Next != null)
            {
                Head = Head.Next;
                Head.Prev = null;
            }

            else
            {
                Head = null;
                Tail = null;
            }

            return element;
        }

        public T DeleteFromTail()
        {
            var element = Tail.Data;
            if (Tail.Prev != null)
            {
                Tail = Tail.Prev;
                Tail.Next = null;
            }

            else
            {
                Head = null;
                Tail = null;
            }

            return element;
        }

        public T Delete(Node<T> data)
        {
            var tempHead = Head;

            while (true)
            {
                if (!tempHead.Equals(data) && tempHead.Next != null)
                {
                    tempHead = tempHead.Next;
                }

                else
                {
                    if (tempHead == Head)
                    {
                        return DeleteFromHead();
                    }

                    else if (tempHead == Tail)
                    {
                        return DeleteFromTail();
                    }

                    else
                    {
                        tempHead.Prev.Next = tempHead.Next;
                        tempHead.Next.Prev = tempHead.Prev;
                        return tempHead.Data;
                    }
                }
            }
        }

        public T DeleteFromPosition(int position)
        {
            var _positionNode = Head;

            for (int x = 0; x < position - 1 ; x++)
            {
                _positionNode = _positionNode.Next;
            }

            if (_positionNode == null)
                throw new InvalidOperationException("Position is out of bounds!");

            var element = _positionNode.Data;

            if (_positionNode.Prev == null)
            {
                _positionNode.Next.Prev = null;
                Head = _positionNode.Next;
            }

            else if (_positionNode.Next == null)
            {
                _positionNode.Prev.Next = null;
                Tail = _positionNode.Prev;
            }

            else
            {
                _positionNode.Prev.Next = _positionNode.Next;
                _positionNode.Next.Prev = _positionNode.Prev;
            }

            return element;
        }

        public T SearchFromPosition(int position)
        {
            var _positionNode = Head;

            for (int x = 0; x < position - 1; x++)
            {
                _positionNode = _positionNode.Next;
            }

            if (_positionNode == null)
                throw new InvalidOperationException("Position is out of bounds!");

            return _positionNode.Data;
        }

        public void PrintNodes()
        {
            Node<T> tempHead = Head;

            while (Head != null)
            {
                Console.Write(Head.Data + ", ");
                Head = Head.Next;
            }

            Head = tempHead;
            Console.WriteLine();
        }
    }
}
