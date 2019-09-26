using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MExer04c
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter integer: ");
            int num = Convert.ToInt32(Console.ReadLine());

            if (palcheck(num) == true)
            {
                Console.WriteLine("Palindrome");
            }

            else
            {
                Console.WriteLine("Not a Palindrome");
            }

            Console.ReadLine();

        }

        public static bool palcheck(int num)
        {          
            int NumDigits = num.ToString().Length;
            int LastDigit = num % 10;
            int FirstDigit = Convert.ToInt32(Math.Floor((num / Math.Pow(10, Convert.ToDouble(NumDigits - 1)))));

            if (NumDigits <= 1)
            {
                return true;
            }

            else if (FirstDigit != LastDigit)
            {
                return false;
            }

            else
            {
                if (num.ToString().Length != 2)
                {
                    string stnum = num.ToString();
                    int nextlength = stnum.Length - 2;
                    int nextnum = Convert.ToInt32(stnum.Substring(1, nextlength));

                    return palcheck(nextnum);
                }

                else
                {
                    return true;
                }
            }
        }
    }
}
