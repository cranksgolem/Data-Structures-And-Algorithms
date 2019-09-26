using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MExer04b
{
    class Program
    {
        static void Main(string[] args)
        {
            cubes(7);
            Console.WriteLine("");
            cubesrec(7);
            Console.ReadLine();
        }

        public static void cubes(int n)
        {
            for (int i = 1;  i <= n; i++)
            {
                Console.WriteLine(i * i * i);
            }
        }

        public static void cubesrec(int n)
        {
            if (n == 1)
            {
                Console.WriteLine(1);
            }

            else
            {
                cubesrec(n - 1);
                Console.WriteLine(n * n * n);
            }

        }
    }
}
