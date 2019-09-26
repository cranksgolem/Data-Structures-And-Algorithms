using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericArrayLinkedList
{
    public class GenericArrayLinkedList<T>
    {
        private T[] _listCurrent = new T[0];
        private T[] _listUpdate = new T[0];

        public T[] ListCurrent
        {
            get { return _listCurrent; }
            set { _listCurrent = value; }
        }

        public T[] ListUpdate
        {
            get { return _listUpdate; }
            set { _listUpdate = value; }
        }

        public void AddToTail(T data)
        {
            ListUpdate = new T[ListCurrent.Length + 1];
            Array.Copy(ListCurrent, ListUpdate, ListCurrent.Length);
            ListUpdate[ListUpdate.Length - 1] = data;
            ListCurrent = ListUpdate;
        }

        public void AddToHead(T data)
        {
            ListUpdate = new T[ListCurrent.Length + 1];
            ListUpdate[0] = data;
            Array.Copy(ListCurrent, 0, ListUpdate, 1, ListCurrent.Length);
            ListCurrent = ListUpdate;
        }

        public void DeleteFromTail()
        {
            ListUpdate = new T[ListCurrent.Length - 1];
            Array.Copy(ListCurrent, 0, ListUpdate, 0, ListCurrent.Length - 1);
            ListCurrent = ListUpdate;
        }

        public T DeleteFromHead()
        {
            var element = ListCurrent[0];
            ListUpdate = new T[ListCurrent.Length - 1];
            Array.Copy(ListCurrent, 1, ListUpdate, 0, ListCurrent.Length - 1);
            ListCurrent = ListUpdate;
            return element;
        }

        public void Delete(T data)
        {
            ListUpdate = new T[ListCurrent.Length - 1];
            bool flag = true;

            for (int x = 0; x < ListCurrent.Length; x++)
            {
                if (ListCurrent[x].Equals(data))
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

            for (int x = 0; x < ListCurrent.Length; x++)
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
