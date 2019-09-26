using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MExer04a
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Series(n).ToString());
            Console.ReadLine();
        }

        public static double Series(double n)
        {
            if (n == 1)
            {
                return 1;
            }
            else
            {

                if (n % 2 > 0)
                {
                    return (-1 / n) + Series(n - 1);
                }

                else
                {
                    return (1 / n) + Series(n - 1);
                }
            }
        }

        public static long Pow(int b, int power)
        {
            if (power == 0)
            {
                return 1;
            }

            return b * Pow(b, power - 1);
        }
    }
}
