using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StackImplementations;

namespace MExer05
{
    class Program
    {
        static void Main(string[] args)
        {
            //char a = 'A';
            //char b = 'B';
            //char c = 'C';
            //Move(3, a, b, c);
            //Console.ReadLine();

            Console.Write("Enter number of disks: ");
            int numdisk = Convert.ToInt32(Console.ReadLine());

            Peg A = new Peg("A", 0);
            Peg B = new Peg("B", 1);
            Peg C = new Peg("C", 2);

            Peg startPeg = new Peg();
            Peg endPeg = new Peg();
            Peg auxPeg = new Peg();

            Console.Write("1 - A\n2 - B\n3 - C\n");

            Console.Write("Select start peg: ");
            int start = Convert.ToInt16(Console.ReadLine());

            Console.Write("Select end peg: ");
            int end = Convert.ToInt16(Console.ReadLine());

            if (start == 1)
            {
                startPeg = A;
            }

            else if (start == 2)
            {
                startPeg = B;
            }

            else if (start == 3)
            {
                startPeg = C;
            }

            if (end == 1)
            {
                endPeg = A;
            }

            else if (end == 2)
            {
                endPeg = B;
            }

            else if (end == 3)
            {
                endPeg = C;
            }

            if ((startPeg == A || endPeg == A) && (endPeg == B || endPeg == B))
            {
                auxPeg = C;
            }

            else if ((startPeg == B || endPeg == B) && (endPeg == C || endPeg == C))
            {
                auxPeg = A;
            }

            else if ((startPeg == A || endPeg == A) && (endPeg == C || endPeg == C))
            {
                auxPeg = B;
            }

            for (int x = numdisk; x > 0; x--)
            {
                startPeg.PegStack.Push(new Disk(x));
            }

            Move(numdisk, startPeg, auxPeg, endPeg);

            Console.ReadLine();

        }

        public static void Move(int n, Peg StartPeg, Peg AuxPeg, Peg EndPeg)
        {
            if (n==1)
            {
                Console.WriteLine("Move Disk" + StartPeg.PegStack.Peek().Number + " From " + StartPeg.Name + " to " + EndPeg.Name);
                EndPeg.PegStack.Push(StartPeg.PegStack.Pop());
            }

            else
            {
                Move(n - 1, StartPeg, EndPeg, AuxPeg);
                Move(1,StartPeg, AuxPeg, EndPeg);
                Move(n - 1, AuxPeg, StartPeg, EndPeg);
            }
        }
    }
}
