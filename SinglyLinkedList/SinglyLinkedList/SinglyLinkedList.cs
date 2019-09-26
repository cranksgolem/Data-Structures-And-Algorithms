using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedList
{
    public class SinglyLinkedList
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }

        public void AddToHead(Node node)
        {
            node.Next = Head;
            Head = node;

            if (Tail == null)
            {
                Tail = Head;
            }
        }

        public void AddToTail(Node node)
        {
            if (Tail != null)
            {
                Tail.Next = node;
            }

            Tail = node;

            if (Head == null)
            {
                Head = Tail;
            }
        }

        public void DeleteFromHead()
        {
            if (Head.Next != null)
            {
                Head = Head.Next;
            }

            else
            {
                Head = null;
                Tail = null;
            }
        }

        public void DeleteFromTail()
        {
            if (Head != Tail)
            {
                var tempHead = Head;

                while (tempHead.Next != Tail)
                {
                    tempHead = tempHead.Next;
                }

                Tail = tempHead;
                Tail.Next = null;
            }

            else
            {
                Tail = null;
                Head = null;
            }
        }

        public void Delete(int data)
        {
            var tempHead = Head;
            var tempHead2 = Head;

            while (true)
            {
                if (tempHead.Data != data)
                {
                    tempHead = tempHead.Next;
                }

                else
                {
                    if (tempHead2 == tempHead)
                    {
                        DeleteFromHead();
                        break;
                    }

                    else
                    {
                        while (tempHead2.Next != tempHead)
                        {
                            tempHead2 = tempHead2.Next;
                        }

                        tempHead2.Next = tempHead.Next;
                        break;
                    }
                }
            }
        }

        public void PrintNodes()
        {
            Node tempHead = Head;

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
