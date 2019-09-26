using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericDoublyLinkedList;

namespace MExer02
{
    class Program
    {
        static void Main(string[] args)
        {
        }
    }

    public interface IQueue<T>
    {
        T Dequeue();

        void Enqueue(T element);

        int Count { get; }

        bool IsEmpty();

        T Peek();

        void Clear();
    }

    public class QueueUsingDoublyLinkedList<T> : IQueue<T>
    {
        private GenericDoublyLinkedList<T> _list = new GenericDoublyLinkedList<T>();

        public int Count { get; private set; }

        public QueueUsingDoublyLinkedList()
        {

        }

        public void Clear()
        {
            _list.Head = null;
            _list.Tail = null;
            Count = 0;
        }

        public bool IsEmpty()
        {
            return _list.Head == null;
        }

        public void Enqueue(T element)
        {
            _list.AddToTail(new Node<T>(element));
            Count++;
        }

        public T Dequeue()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Queue is empty.");
            var dequeued = _list.DeleteFromHead();
            Count--;
            return dequeued;
        }

        public T Peek()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Queue is empty.");

            return _list.Head.Data;
        }
    }
}
