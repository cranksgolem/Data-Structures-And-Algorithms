using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    public class LinkedListUsingArray
    {
        private int[] _listCurrent = new int[0];
        private int[] _listUpdate = new int[0];

        public int[] ListCurrent
        {
            get { return _listCurrent; }
            set { _listCurrent = value; }
        }

        public int[] ListUpdate
        {
            get { return _listUpdate; }
            set { _listUpdate = value; }
        }

        public void AddToTail(int data)
        {
            ListUpdate = new int[ListCurrent.Length + 1];
            Array.Copy(ListCurrent, ListUpdate, ListCurrent.Length);
            ListUpdate[ListUpdate.Length - 1] = data;
            ListCurrent = ListUpdate;
        }

        public void AddToHead(int data)
        {
            ListUpdate = new int[ListCurrent.Length + 1];
            ListUpdate[0] = data;
            Array.Copy(ListCurrent, 0, ListUpdate, 1, ListCurrent.Length);
            ListCurrent = ListUpdate;
        }

        public void DeleteFromTail()
        {
            ListUpdate = new int[ListCurrent.Length - 1];
            Array.Copy(ListCurrent, 0, ListUpdate, 0, ListCurrent.Length - 1);
            ListCurrent = ListUpdate;
        }

        public void DeleteFromHead()
        {
            ListUpdate = new int[ListCurrent.Length - 1];
            Array.Copy(ListCurrent, 1, ListUpdate, 0, ListCurrent.Length - 1);
            ListCurrent = ListUpdate;
        }

        public void Delete(int data)
        {
            ListUpdate = new int[ListCurrent.Length - 1];
            bool flag = true;

            for (int x = 0; x < ListCurrent.Length; x++)
            {
                if (ListCurrent[x] == data)
                {
                    if (flag == false)
                    {
                        ListUpdate[x - 1] = ListCurrent[x];
                    }

                    else
                    {
                        flag = false;
                    }
                }

                else
                {
                    if (flag == false)
                    {
                        ListUpdate[x - 1] = ListCurrent[x];
                    }

                    else
                    {
                        ListUpdate[x] = ListCurrent[x];
                    }
                }
            }

            ListCurrent = ListUpdate;
        }

        public void PrintNodes()
        {
            Console.Write("\noutput: ");

            for (int x = 0; x < ListCurrent.Length ; x++)
            {
                if (x == ListCurrent.Length - 1)
                {
                    Console.Write(ListCurrent[x]);
                }

                else
                {
                    Console.Write(ListCurrent[x] + ", ");
                }
            }
        }
    }
}
