using System;

namespace LinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList potatoList = new LinkedList(1);

            potatoList.AddNode(15);
            potatoList.AddNode(64);
            potatoList.AddNode(22);
            potatoList.AddNode(48);
            potatoList.AddNode(89);
            potatoList.AddNode(76);
            potatoList.AddNode(52);
            potatoList.AddToFirst(0);

            potatoList.ViewLinkedList();

            //potatoList.FindCenterNode();
            //potatoList.NthNodeFromEnd(2);
            //potatoList.DataNFromEnd(22);

            potatoList.DeleteByData(22);
            potatoList.ViewLinkedList();

            Console.Read();
        }
    }
}