using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericDoublyLinkedList;
using GenericArrayLinkedList;
using System.Diagnostics;

namespace StackImplementations
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch timer = new Stopwatch();
            StackUsingLinkedList<int> _list1 = new StackUsingLinkedList<int>();
            StackUsingArray<int> _list2 = new StackUsingArray<int>();

            timer.Start();
            for(int x = 0; x < 1; x++)
            {
                _list1.Push(x);
            }
            timer.Stop();
            Console.WriteLine(timer.Elapsed);
            timer.Reset();
            _list1 = new StackUsingLinkedList<int>();

            timer.Start();
            for (int x = 0; x < 10; x++)
            {
                _list1.Push(x);
            }
            timer.Stop();
            Console.WriteLine(timer.Elapsed);
            timer.Reset();
            _list1 = new StackUsingLinkedList<int>();

            timer.Start();
            for (int x = 0; x < 100; x++)
            {
                _list1.Push(x);
            }
            timer.Stop();
            Console.WriteLine(timer.Elapsed);
            timer.Reset();
            _list1 = new StackUsingLinkedList<int>();

            timer.Start();
            for (int x = 0; x < 1000; x++)
            {
                _list1.Push(x);
            }
            timer.Stop();
            Console.WriteLine(timer.Elapsed);
            timer.Reset();
            _list1 = new StackUsingLinkedList<int>();

            timer.Start();
            for (int x = 0; x < 10000; x++)
            {
                _list1.Push(x);
            }
            timer.Stop();
            Console.WriteLine(timer.Elapsed);
            timer.Reset();
            _list1 = new StackUsingLinkedList<int>();

            Console.WriteLine();

            timer.Start();
            for (int x = 0; x < 1; x++)
            {
                _list2.Push(x);
            }
            timer.Stop();
            Console.WriteLine(timer.Elapsed);
            timer.Reset();
            _list2 = new StackUsingArray<int>();

            timer.Start();
            for (int x = 0; x < 10; x++)
            {
                _list2.Push(x);
            }
            timer.Stop();
            Console.WriteLine(timer.Elapsed);
            timer.Reset();
            _list2 = new StackUsingArray<int>();

            timer.Start();
            for (int x = 0; x < 100; x++)
            {
                _list2.Push(x);
            }
            timer.Stop();
            Console.WriteLine(timer.Elapsed);
            timer.Reset();
            _list2 = new StackUsingArray<int>();

            timer.Start();
            for (int x = 0; x < 1000; x++)
            {
                _list2.Push(x);
            }
            timer.Stop();
            Console.WriteLine(timer.Elapsed);
            timer.Reset();
            _list2 = new StackUsingArray<int>();

            timer.Start();
            for (int x = 0; x < 10000; x++)
            {
                _list2.Push(x);
            }
            timer.Stop();
            Console.WriteLine(timer.Elapsed);
            timer.Reset();
            _list2 = new StackUsingArray<int>();

            Console.ReadLine();
        }
    }

    public interface IStack<T>
    {
        int Count { get; }

        void Clear();

        bool IsEmpty();

        void Push(T element);

        T Pop();

        T Peek();
    }

    public class StackUsingLinkedList<T> : IStack<T>
    {
        private GenericDoublyLinkedList<T> _list = new GenericDoublyLinkedList<T>();

        public int Count { get; private set; }

        public StackUsingLinkedList()
        {

        }

        public void Clear()
        {
            _list.Head = null;
            _list.Tail = null;
        }

        public bool IsEmpty()
        {
            return _list.Head == null;
        }

        public void Push(T element)
        {
            _list.AddToHead(new Node<T>(element));
            Count++;
        }

        public T Pop()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Stack is empty.");
            var popped = _list.DeleteFromHead();         
            Count--;
            return popped;
        }

        public T Peek()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Stack is empty.");

            return _list.Head.Data;
        }
    }

    public class StackUsingArray<T> : IStack<T>
    {
        private GenericArrayLinkedList<T> _list = new GenericArrayLinkedList<T>();

        public int Count { get; private set; }

        public void Clear()
        {
            _list.ListCurrent = new T[0];
        }

        public bool IsEmpty()
        {
            return _list.ListCurrent[0] == null;
        }

        public void Push(T element)
        {
            _list.AddToHead(element);
            Count++;
        }

        public T Pop()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Stack is empty.");
            var popped = _list.DeleteFromHead();
            Count--;
            return popped;
        }

        public T Peek()
        {
            if (IsEmpty())
                throw new InvalidOperationException("Stack is empty.");

            return _list.ListCurrent[0];
        }
    }

}
