using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace DoublyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = new DoublyLinkedList();
            Stopwatch timer = new Stopwatch();

            //for (int y = 0; y < 1; y++ )
            //{
            //    x.AddToHead(new Node(y));
            //}

            //timer.Start();

            //for (int y = 0; y < 1; y++ )
            //{
            //    x.Delete(y);
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
            //    x.Delete(y);
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
            //    x.Delete(y);
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
            //    x.Delete(y);
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
            //    x.Delete(y);
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
            //    x.Delete(y);
            //}
            //timer.Stop();
            //Console.WriteLine(timer.Elapsed);
            //timer.Reset();

            for (int y = 0; y < 1; y++ )
            {
                x.AddToHead(new Node(y));
            }

            timer.Start();

            for (int y = 0; y < 1; y++)
            {
                x.DeleteFromTail();
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
                x.DeleteFromTail();
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
                x.DeleteFromTail();
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
                x.DeleteFromTail();
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
                x.DeleteFromTail();
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
                x.DeleteFromTail();
            }

            timer.Stop();
            Console.WriteLine(timer.Elapsed);
            timer.Reset();

            Console.ReadLine();
        }
    }
}
