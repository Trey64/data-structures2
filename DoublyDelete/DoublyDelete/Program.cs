using System;

namespace DoublyDelete
{
    class Program
    {
        static void Main(string[] args)
        {
            DoublyLinkedList tomatoList = new DoublyLinkedList(4);

            Console.WriteLine("Doubly list with nodes added to first");
            tomatoList.AddFirst(43);
            tomatoList.AddFirst(27);
            tomatoList.AddFirst(13);
            tomatoList.AddFirst(88);

            tomatoList.ViewDoublyList();

            Console.WriteLine();
            Console.WriteLine("Doubly list with nodes added to last");
            tomatoList.AddLast(42);
            tomatoList.AddLast(76);
            tomatoList.AddLast(64);

            tomatoList.ViewDoublyList();

            Console.WriteLine();
            Console.WriteLine("Doubly list with first node removed");
            tomatoList.RemoveFirst();
            tomatoList.ViewDoublyList();

            Console.WriteLine();
            Console.WriteLine("Doubly list with node containing 13 removed");
            tomatoList.Remove(13);
            tomatoList.ViewDoublyList();

            Console.Read();

        }
    }
}