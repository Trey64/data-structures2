using System;
using System.Collections.Generic;
using System.Text;

namespace DoublyDelete
{
    public class DoublyLinkedList
    {
        public Node Next { get; set; }

        public DoublyLinkedList(int data)
        {
            Next = new Node(data);
        }

        public void ViewDoublyList()
        {
            Node runner = Next;
            string printOut = "";

            while (runner.Next != null)
            {
                printOut += runner.Data + " <-> ";
                runner = runner.Next;
            }

            printOut += runner.Data + " <-> null";
            Console.WriteLine(printOut);
        }

        public void AddLast(int data)
        {
            Node runner = Next;
            while (runner.Next != null)
            {
                runner = runner.Next;
            }
            runner.Next = new Node(data);
            runner.Next.Previous = runner;
        }

        public Node Remove(int data)
        {
            Node runner = Next;
            if (runner.Data == data)
            {
                return RemoveFirst();
            }
            else
            {
                while (runner.Next != null && runner.Data != data)
                {
                    runner = runner.Next;
                }
                if (runner.Data != data)
                {
                    Console.WriteLine("Didn't find data");
                    return runner;
                }
                else
                {
                    runner.Previous.Next = runner.Next;
                    runner.Next.Previous = runner.Previous;
                    runner.Next = null;
                    runner.Previous = null;
                    return runner;
                }
            }
        }

        public Node RemoveFirst()
        {
            Node current = Next;
            Next = Next.Next;
            Next.Previous = null;
            current.Next = null;
            return current;
        }

        public void AddFirst(int data)
        {
            Node current = Next;
            Next = new Node(data);
            Next.Next = current;
            current.Previous = Next;

        }


    }
}