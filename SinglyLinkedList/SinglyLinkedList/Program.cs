using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace SinglyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = new SinglyLinkedList();

            var timer = new Stopwatch();
            //timer.Start();
            //x.AddToHead(new Node(5));
            //timer.Stop();
            //Console.WriteLine(timer.Elapsed);
            //timer.Reset();
            //x.AddToHead(new Node(3));
            //timer.Start();
            //x.AddToHead(new Node(1));
            //timer.Stop();
            //Console.WriteLine(timer.Elapsed);
            //timer.Reset();

            //x.PrintNodes();

            //x.AddToHead(new Node(4));

            //x.PrintNodes();

            //var timer = new Stopwatch();

            //timer.Start();

            //for (int y = 0; y < 1; y++)
            //{
            //    x.AddToHead(new Node(y));
            //}

            //timer.Stop();
            //Console.WriteLine(timer.Elapsed);
            //timer.Reset();

            //timer.Start();

            //for (int y = 0; y < 3; y++)
            //{
            //    x.AddToHead(new Node(y));
            //}

            //timer.Stop();
            //Console.WriteLine(timer.Elapsed);
            //timer.Reset();

            //timer.Start();

            //for (int y = 0; y < 5; y++)
            //{
            //    x.AddToHead(new Node(y));
            //}

            //timer.Stop();
            //Console.WriteLine(timer.Elapsed);
            //timer.Reset();

            //timer.Start();

            //for (int y = 0; y < 10; y++)
            //{
            //    x.AddToHead(new Node(y));
            //}

            //timer.Stop();
            //Console.WriteLine(timer.Elapsed);
            //timer.Reset();

            //timer.Start();

            //for (int y = 0; y < 100; y++)
            //{
            //    x.AddToHead(new Node(y));
            //}

            //timer.Stop();
            //Console.WriteLine(timer.Elapsed);
            //timer.Reset();

            //timer.Start();

            //for (int y = 0; y < 1000; y++)
            //{
            //    x.AddToHead(new Node(y));
            //}

            //timer.Stop();
            //Console.WriteLine(timer.Elapsed);
            //timer.Reset();

            //x = new SinglyLinkedList();

            //x.AddToTail(new Node(5));
            //x.AddToTail(new Node(3));
            //x.AddToTail(new Node(1));

            //x.PrintNodes();
            //Console.WriteLine();
            //x = new SinglyLinkedList();

            //timer.Start();

            //for (int y = 0; y < 1; y++)
            //{
            //    x.AddToTail(new Node(y));
            //}

            //timer.Stop();
            //Console.WriteLine(timer.Elapsed);
            //timer.Reset();

            //timer.Start();

            //for (int y = 0; y < 3; y++)
            //{
            //    x.AddToTail(new Node(y));
            //}

            //timer.Stop();
            //Console.WriteLine(timer.Elapsed);
            //timer.Reset();

            //timer.Start();

            //for (int y = 0; y < 5; y++)
            //{
            //    x.AddToTail(new Node(y));
            //}

            //timer.Stop();
            //Console.WriteLine(timer.Elapsed);
            //timer.Reset();

            //timer.Start();

            //for (int y = 0; y < 10; y++)
            //{
            //    x.AddToTail(new Node(y));
            //}

            //timer.Stop();
            //Console.WriteLine(timer.Elapsed);
            //timer.Reset();

            //timer.Start();

            //for (int y = 0; y < 100; y++)
            //{
            //    x.AddToTail(new Node(y));
            //}

            //timer.Stop();
            //Console.WriteLine(timer.Elapsed);
            //timer.Reset();

            //timer.Start();

            //for (int y = 0; y < 1000; y++)
            //{
            //    x.AddToTail(new Node(y));
            //}

            //timer.Stop();
            //Console.WriteLine(timer.Elapsed);
            //timer.Reset();

            //Console.WriteLine();

            //x = new SinglyLinkedList();

            //for (int y = 0; y < 1; y++)
            //{
            //    x.AddToHead(new Node(y));
            //}

            //timer.Start();

            //for (int y = 0; y < 1; y++ )
            //{
            //    x.DeleteFromHead();
            //}

            //timer.Stop();
            //Console.WriteLine(timer.Elapsed);
            //timer.Reset();

            //for (int y = 0; y < 3; y++)
            //{
            //    x.AddToHead(new Node(y));
            //}

            //timer.Start();

            //for (int y = 0; y < 3; y++)
            //{
            //    x.DeleteFromHead();
            //}

            //timer.Stop();
            //Console.WriteLine(timer.Elapsed);
            //timer.Reset();

            //for (int y = 0; y < 5; y++)
            //{
            //    x.AddToHead(new Node(y));
            //}

            //timer.Start();

            //for (int y = 0; y < 5; y++)
            //{
            //    x.DeleteFromHead();
            //}

            //timer.Stop();
            //Console.WriteLine(timer.Elapsed);
            //timer.Reset();

            //for (int y = 0; y < 10; y++)
            //{
            //    x.AddToHead(new Node(y));
            //}

            //timer.Start();

            //for (int y = 0; y < 10; y++)
            //{
            //    x.DeleteFromHead();
            //}

            //timer.Stop();
            //Console.WriteLine(timer.Elapsed);
            //timer.Reset();

            //for (int y = 0; y < 100; y++)
            //{
            //    x.AddToHead(new Node(y));
            //}

            //timer.Start();

            //for (int y = 0; y < 100; y++)
            //{
            //    x.DeleteFromHead();
            //}

            //timer.Stop();
            //Console.WriteLine(timer.Elapsed);
            //timer.Reset();

            //for (int y = 0; y < 1000; y++)
            //{
            //    x.AddToHead(new Node(y));
            //}

            //timer.Start();

            //for (int y = 0; y < 1000; y++)
            //{
            //    x.DeleteFromHead();
            //}

            //timer.Stop();
            //Console.WriteLine(timer.Elapsed);
            //timer.Reset();

            //Console.WriteLine();

            //x = new SinglyLinkedList();

            //for (int y = 0; y < 1; y++)
            //{
            //    x.AddToHead(new Node(y));
            //}

            //timer.Start();

            //for (int y = 0; y < 1; y++)
            //{
            //    x.DeleteFromTail();
            //}

            //timer.Stop();
            //Console.WriteLine(timer.Elapsed);
            //timer.Reset();

            //for (int y = 0; y < 3; y++)
            //{
            //    x.AddToHead(new Node(y));
            //}

            //timer.Start();

            //for (int y = 0; y < 3; y++)
            //{
            //    x.DeleteFromTail();
            //}

            //timer.Stop();
            //Console.WriteLine(timer.Elapsed);
            //timer.Reset();

            //for (int y = 0; y < 5; y++)
            //{
            //    x.AddToHead(new Node(y));
            //}

            //timer.Start();

            //for (int y = 0; y < 5; y++)
            //{
            //    x.DeleteFromTail();
            //}

            //timer.Stop();
            //Console.WriteLine(timer.Elapsed);
            //timer.Reset();

            //for (int y = 0; y < 10; y++)
            //{
            //    x.AddToHead(new Node(y));
            //}

            //timer.Start();

            //for (int y = 0; y < 10; y++)
            //{
            //    x.DeleteFromTail();
            //}

            //timer.Stop();
            //Console.WriteLine(timer.Elapsed);
            //timer.Reset();

            //for (int y = 0; y < 100; y++)
            //{
            //    x.AddToHead(new Node(y));
            //}

            //timer.Start();

            //for (int y = 0; y < 100; y++)
            //{
            //    x.DeleteFromTail();
            //}

            //timer.Stop();
            //Console.WriteLine(timer.Elapsed);
            //timer.Reset();

            //for (int y = 0; y < 1000; y++)
            //{
            //    x.AddToHead(new Node(y));
            //}

            //timer.Start();

            //for (int y = 0; y < 1000; y++)
            //{
            //    x.DeleteFromTail();
            //}

            //timer.Stop();
            //Console.WriteLine(timer.Elapsed);
            //timer.Reset();

            for (int y = 0; y < 1; y++ )
            {
                x.AddToHead(new Node(y));
            }

            timer.Start();

            for (int y = 0; y < 1; y++ )
            {
                x.Delete(y);
            }
            timer.Stop();
            Console.WriteLine(timer.Elapsed);
            timer.Reset();

            for (int y = 0; y < 3; y++)
            {
                x.AddToHead(new Node(y));
            }

            timer.Start();

            for (int y = 0; y < 3; y++)
            {
                x.Delete(y);
            }
            timer.Stop();
            Console.WriteLine(timer.Elapsed);
            timer.Reset();

            for (int y = 0; y < 5; y++)
            {
                x.AddToHead(new Node(y));
            }

            timer.Start();

            for (int y = 0; y < 5; y++)
            {
                x.Delete(y);
            }
            timer.Stop();
            Console.WriteLine(timer.Elapsed);
            timer.Reset();

            for (int y = 0; y < 10; y++)
            {
                x.AddToHead(new Node(y));
            }

            timer.Start();

            for (int y = 0; y < 10; y++)
            {
                x.Delete(y);
            }
            timer.Stop();
            Console.WriteLine(timer.Elapsed);
            timer.Reset();

            for (int y = 0; y < 100; y++)
            {
                x.AddToHead(new Node(y));
            }

            timer.Start();

            for (int y = 0; y < 100; y++)
            {
                x.Delete(y);
            }
            timer.Stop();
            Console.WriteLine(timer.Elapsed);
            timer.Reset();

            for (int y = 0; y < 1000; y++)
            {
                x.AddToHead(new Node(y));
            }

            timer.Start();

            for (int y = 0; y < 1000; y++)
            {
                x.Delete(y);
            }
            timer.Stop();
            Console.WriteLine(timer.Elapsed);
            timer.Reset();

            Console.ReadLine();
        }
    }
}
