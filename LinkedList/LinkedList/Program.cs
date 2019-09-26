using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedListUsingArray list = new LinkedListUsingArray();
            var timer = new Stopwatch();
            //timer.Start();
            //list.AddToHead(4);
            //timer.Stop();
            //Console.WriteLine(timer.Elapsed);
            //timer.Reset();
            //list.AddToHead(3);
            //timer.Start();
            //list.AddToHead(1);
            //timer.Stop();
            //Console.WriteLine(timer.Elapsed);
            //timer.Reset();
            //list.PrintNodes(); // output: 3, 4
            //list.AddToTail(1);
            //list.PrintNodes(); // output: 3, 4, 1
            //list.DeleteFromHead();
            //list.PrintNodes(); // output 4, 1
            //list.DeleteFromTail(); // output 4
            //list.PrintNodes();
            //var timer = new Stopwatch();
            //timer.Start();

            //for (int y = 0; y < 1; y++)
            //{
            //    list.AddToHead(y);
            //}

            //timer.Stop();
            //Console.WriteLine(timer.Elapsed);
            //timer.Reset();

            //timer.Start();

            //for (int y = 0; y < 3; y++)
            //{
            //    list.AddToHead(y);
            //}

            //timer.Stop();
            //Console.WriteLine(timer.Elapsed);
            //timer.Reset();

            //timer.Start();

            //for (int y = 0; y < 5; y++)
            //{
            //    list.AddToHead(y);
            //}

            //timer.Stop();
            //Console.WriteLine(timer.Elapsed);
            //timer.Reset();

            //timer.Start();

            //for (int y = 0; y < 10; y++)
            //{
            //    list.AddToHead(y);
            //}

            //timer.Stop();
            //Console.WriteLine(timer.Elapsed);
            //timer.Reset();

            //timer.Start();

            //for (int y = 0; y < 100; y++)
            //{
            //    list.AddToHead(y);
            //}

            //timer.Stop();
            //Console.WriteLine(timer.Elapsed);
            //timer.Reset();

            //timer.Start();

            //for (int y = 0; y < 1000; y++)
            //{
            //    list.AddToHead(y);
            //}

            //timer.Stop();
            //Console.WriteLine(timer.Elapsed);
            //timer.Reset();

            //Console.WriteLine();

            //list = new LinkedListUsingArray();

            //timer.Start();

            //for (int y = 0; y < 1; y++)
            //{
            //    list.AddToTail(y);
            //}

            //timer.Stop();
            //Console.WriteLine(timer.Elapsed);
            //timer.Reset();

            //timer.Start();

            //for (int y = 0; y < 3; y++)
            //{
            //    list.AddToTail(y);
            //}

            //timer.Stop();
            //Console.WriteLine(timer.Elapsed);
            //timer.Reset();

            //timer.Start();

            //for (int y = 0; y < 5; y++)
            //{
            //    list.AddToTail(y);
            //}

            //timer.Stop();
            //Console.WriteLine(timer.Elapsed);
            //timer.Reset();

            //timer.Start();

            //for (int y = 0; y < 10; y++)
            //{
            //    list.AddToTail(y);
            //}

            //timer.Stop();
            //Console.WriteLine(timer.Elapsed);
            //timer.Reset();

            //timer.Start();

            //for (int y = 0; y < 100; y++)
            //{
            //    list.AddToTail(y);
            //}

            //timer.Stop();
            //Console.WriteLine(timer.Elapsed);
            //timer.Reset();

            //timer.Start();

            //for (int y = 0; y < 1000; y++)
            //{
            //    list.AddToTail(y);
            //}

            //timer.Stop();
            //Console.WriteLine(timer.Elapsed);
            //timer.Reset();

            //Console.WriteLine();

            //list = new LinkedListUsingArray();

            //for (int y = 0; y < 1; y++)
            //{
            //    list.AddToHead(y);
            //}

            //timer.Start();

            //for (int y = 0; y < 1; y++)
            //{
            //    list.DeleteFromHead();
            //}

            //timer.Stop();
            //Console.WriteLine(timer.Elapsed);
            //timer.Reset();

            //for (int y = 0; y < 3; y++)
            //{
            //    list.AddToHead(y);
            //}

            //timer.Start();

            //for (int y = 0; y < 3; y++)
            //{
            //    list.DeleteFromHead();
            //}

            //timer.Stop();
            //Console.WriteLine(timer.Elapsed);
            //timer.Reset();

            //for (int y = 0; y < 5; y++)
            //{
            //    list.AddToHead(y);
            //}

            //timer.Start();

            //for (int y = 0; y < 5; y++)
            //{
            //    list.DeleteFromHead();
            //}

            //timer.Stop();
            //Console.WriteLine(timer.Elapsed);
            //timer.Reset();

            //for (int y = 0; y < 10; y++)
            //{
            //    list.AddToHead(y);
            //}

            //timer.Start();

            //for (int y = 0; y < 10; y++)
            //{
            //    list.DeleteFromHead();
            //}

            //timer.Stop();
            //Console.WriteLine(timer.Elapsed);
            //timer.Reset();

            //for (int y = 0; y < 100; y++)
            //{
            //    list.AddToHead(y);
            //}

            //timer.Start();

            //for (int y = 0; y < 100; y++)
            //{
            //    list.DeleteFromHead();
            //}

            //timer.Stop();
            //Console.WriteLine(timer.Elapsed);
            //timer.Reset();

            //for (int y = 0; y < 1000; y++)
            //{
            //    list.AddToHead(y);
            //}

            //timer.Start();

            //for (int y = 0; y < 1000; y++)
            //{
            //    list.DeleteFromHead();
            //}

            //timer.Stop();
            //Console.WriteLine(timer.Elapsed);
            //timer.Reset();

            //Console.WriteLine();

            //list = new LinkedListUsingArray();

            //for (int y = 0; y < 1; y++)
            //{
            //    list.AddToHead(y);
            //}

            //timer.Start();

            //for (int y = 0; y < 1; y++)
            //{
            //    list.DeleteFromTail();
            //}

            //timer.Stop();
            //Console.WriteLine(timer.Elapsed);
            //timer.Reset();

            //for (int y = 0; y < 3; y++)
            //{
            //    list.AddToHead(y);
            //}

            //timer.Start();

            //for (int y = 0; y < 3; y++)
            //{
            //    list.DeleteFromTail();
            //}

            //timer.Stop();
            //Console.WriteLine(timer.Elapsed);
            //timer.Reset();

            //for (int y = 0; y < 5; y++)
            //{
            //    list.AddToHead(y);
            //}

            //timer.Start();

            //for (int y = 0; y < 5; y++)
            //{
            //    list.DeleteFromTail();
            //}

            //timer.Stop();
            //Console.WriteLine(timer.Elapsed);
            //timer.Reset();

            //for (int y = 0; y < 10; y++)
            //{
            //    list.AddToHead(y);
            //}

            //timer.Start();

            //for (int y = 0; y < 10; y++)
            //{
            //    list.DeleteFromTail();
            //}

            //timer.Stop();
            //Console.WriteLine(timer.Elapsed);
            //timer.Reset();

            //for (int y = 0; y < 100; y++)
            //{
            //    list.AddToHead(y);
            //}

            //timer.Start();

            //for (int y = 0; y < 100; y++)
            //{
            //    list.DeleteFromTail();
            //}

            //timer.Stop();
            //Console.WriteLine(timer.Elapsed);
            //timer.Reset();

            //for (int y = 0; y < 1000; y++)
            //{
            //    list.AddToHead(y);
            //}

            //timer.Start();

            //for (int y = 0; y < 1000; y++)
            //{
            //    list.DeleteFromTail();
            //}

            //timer.Stop();
            //Console.WriteLine(timer.Elapsed);
            //timer.Reset();

            for (int y = 0; y < 1; y++ )
            {
                list.AddToHead(y);
            }

            timer.Start();

            for (int y = 0; y < 1; y++ )
            {
                list.Delete(y);
            }

            timer.Stop();
            Console.WriteLine(timer.Elapsed);
            timer.Reset();

            for (int y = 0; y < 3; y++)
            {
                list.AddToHead(y);
            }

            timer.Start();

            for (int y = 0; y < 3; y++)
            {
                list.Delete(y);
            }

            timer.Stop();
            Console.WriteLine(timer.Elapsed);
            timer.Reset();

            for (int y = 0; y < 5; y++)
            {
                list.AddToHead(y);
            }

            timer.Start();

            for (int y = 0; y < 5; y++)
            {
                list.Delete(y);
            }

            timer.Stop();
            Console.WriteLine(timer.Elapsed);
            timer.Reset();

            for (int y = 0; y < 10; y++)
            {
                list.AddToHead(y);
            }

            timer.Start();

            for (int y = 0; y < 10; y++)
            {
                list.Delete(y);
            }

            timer.Stop();
            Console.WriteLine(timer.Elapsed);
            timer.Reset();

            for (int y = 0; y < 100; y++)
            {
                list.AddToHead(y);
            }

            timer.Start();

            for (int y = 0; y < 100; y++)
            {
                list.Delete(y);
            }

            timer.Stop();
            Console.WriteLine(timer.Elapsed);
            timer.Reset();

            for (int y = 0; y < 1000; y++)
            {
                list.AddToHead(y);
            }

            timer.Start();

            for (int y = 0; y < 1000; y++)
            {
                list.Delete(y);
            }

            timer.Stop();
            Console.WriteLine(timer.Elapsed);
            timer.Reset();

            Console.ReadLine();
        }
    }
}
