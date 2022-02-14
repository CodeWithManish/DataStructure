using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class LinkedListQueue
    {
        Node head = null;
        public void Enqueue(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;

                }
                temp.next = node;
            }
            Console.WriteLine("{0} Inserted into Queue", node.data);
        }



        public void Display()
        {
            Console.WriteLine("\n========Display Queues========\n");
            Node temp = head;
            if (temp == null)
            {
                Console.WriteLine("Queue is empty!");
                return;

            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + "");
                temp = temp.next;
            }
        }
        public void Dequeue()
        {
            if (head == null)
            {
                Console.WriteLine("The Queue is empty");
                return;

            }
            int Deletedata = head.data;
            head = head.next;
            Console.WriteLine("\n{0} is deleted from queue", Deletedata);
        }

        

    }
}
