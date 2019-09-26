using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoublyLinkedList
{
    public class DoublyLinkedList
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }

        public void AddToHead(Node node)
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

        public void AddToTail(Node node)
        {
            if (Tail != null)
            {
                Tail.Next = node;
                node.Prev = Tail;
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
                Head.Prev = null;
            }

            else
            {
                Head = null;
                Tail = null;
            }
        }

        public void DeleteFromTail()
        {
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
        }

        public void Delete(int data)
        {        
            var tempHead = Head;

            while (true)
            {
                if (tempHead.Data != data && tempHead.Next != null)
                {
                    tempHead = tempHead.Next;
                }

                else
                {
                    if (tempHead == Head)
                    {
                        DeleteFromHead();
                        break;
                    }

                    else if (tempHead == Tail)
                    {
                        DeleteFromTail();
                        break;
                    }

                    else
                    {
                        tempHead.Prev.Next = tempHead.Next;
                        tempHead.Next.Prev = tempHead.Prev;
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
