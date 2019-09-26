using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDoublyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            //var list = new GenericDoublyLinkedList<Person>();

            //list.AddToHead(new Node<Person>(new Person("RJ", "F309")));
            //list.AddToHead(new Node<Person>(new Person("Kim", "F319")));
            //list.AddToHead(new Node<Person>(new Person("July", "F409")));
            //list.AddToHead(new Node<Person>(new Person("Yhuds", "F329")));
            //list.AddToHead(new Node<Person>(new Person("Justin", "F362")));

            //list.PrintNodes();

            //var search = list.Head;

            //while (search.Data.Name != "Kim")
            //{
            //    search = search.Next;
            //}

            //list.Delete(search);

            //list.PrintNodes();
            //Console.ReadLine();

            var list = new GenericDoublyLinkedList<string>();

            list.AddToHead(new Node<string>("1"));
            list.AddToHead(new Node<string>("2"));
            list.AddToHead(new Node<string>("3"));
            list.AddToHead(new Node<string>("4"));
            list.AddToHead(new Node<string>("5"));
            list.AddToHead(new Node<string>("6"));

            list.PrintNodes();

            Console.WriteLine(list.SearchFromPosition(3));

            list.PrintNodes();

            Console.ReadLine();
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public string Address { get; set; }

        public Person(string name)
        {
            Name = name;
        }

        public Person(string name, string address)
        {
            Name = name;
            Address = address;
        }

        public override string ToString()
        {
            return string.Format("{0} : {1}", Name, Address);
        }
    }
}
