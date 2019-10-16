using System;
using System.Collections.Generic;

namespace _15_Linked_Lists
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var input = new[] { 2, 3, 4, 1 };
            Node head = null;
            int T = input.Length;
            // TODO: TALK ABOUT THIS AND WHY ITS NOT GOOD
           foreach(var value in input)
            {
                //int data = Int32.Parse(Console.ReadLine());
                //int data = input[T];
                head = insert(head, value);
            }
            display(head);
        }

        public static Node insert(Node head, int data)
        {
            //Complete this method
            if (head == null)
            {
                head = new Node(data);
            }
            else
            {
                var temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }

                temp.next = new Node(data);
            }

            return head;
        }

        public static void display(Node head)
        {
            Node start = head;
            while (start != null)
            {
                Console.Write(start.data + " ");
                start = start.next;
            }
        }
    }
}
