using System;

namespace LinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList potatoList = new LinkedList(1);

            potatoList.AddNode(2);
            potatoList.AddNode(3);
            potatoList.AddNode(4);
            potatoList.AddToFirst(0);
            potatoList.ViewLinkedList();
            Console.Read();
        }
    }
}