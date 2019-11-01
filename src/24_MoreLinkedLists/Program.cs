using System;

namespace _24_MoreLinkedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] inputs = new int[] {1,2,2,3,3,4};
            
            Node temp = null;
            foreach(int input in inputs)
            {
                temp = insert(temp, input);
            }
            display(temp);

            temp = RemoveDuplicates(temp);
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

        public static Node insert(Node head, int data)
        {
            Node p = new Node(data);


            if (head == null)
                head = p;
            else if (head.next == null)
                head.next = p;
            else
            {
                Node start = head;
                while (start.next != null)
                    start = start.next;
                start.next = p;

            }
            return head;
        }

        public static Node RemoveDuplicates(Node head)
        {
            int dataValue = Int32.MinValue;
            Node temp = head, previous = null;
            while (temp.next != null)
            {
                if (temp.data > dataValue)
                {
                    dataValue = temp.data;
                    previous = temp;
                    temp = temp.next;
                }
                else
                {
                    previous.next = temp.next;
                    temp = previous;
                }
            }
            /*Head.Data = start
             while (head.data != null)
            {
                1 Increase a temp counter for current value
                2 Move to the next node
                3. If the next node value == current value, remove this duplicate
            }*/
            return head;
        }
    }
}
