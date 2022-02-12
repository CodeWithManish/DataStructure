using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class LinkedList
    {
        public Node head;
        public void Add(int data)
        {
            Node node = new Node(data);
            if(head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                while(temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into linked List",node.data);
        }


        public void AddInReverseOrder(int data)
        {
            Node newNode=new Node(data);
            if(head != null)
            {
                head.next = newNode;
            }
            else
            {
                Node temp=head;
                head = newNode;
                head.next = temp;
            }
           
        }

        public Node DeleteFirstNode(int data)
        {
            if(head == null)
            {
                return null;
            }
            head=head.next;
            return head;
            Console.WriteLine("List is already empty");
        }


        public Node DeleteLastNode(int data)
        {
            if(head == null)
            {
                return null;
            }
            if(head.next == null)
            {
                return null;
            }
            Node NewNode = head;
            while (NewNode.next.next != null)
            {
                NewNode = NewNode.next;
            }
            NewNode.next = null;
            return head;
            Console.WriteLine("deleted last node!");
        }

        public int Search(int value)
        {
            Node node = head;
            int count = 0;
            while(node != null)
            {
                if(node.data == value)
                {
                    return count;
                }
                node = node.next;
                count++;
            }
            return -1;

        }


        public void DeleteNodeAtParticularPosition(int pos)
        {
            if(head == null)
            {
                Console.WriteLine("Linked list is empty");
                return;
            }
            Node temp=head;
            if(pos == 0)
            {
                head=temp.next;
                return;
            }
            for(int i=0; temp != null && i < pos-1; i++)
            {
                temp=temp.next;
            }
            if(temp == null || temp.next == null)
            {
                return;
            }
            Node next=temp.next.next;
            temp.next=next;
        }

        public void Size()
        {
            Node temp=head;
            int count=0;
            if(temp == null)
            {
                Console.WriteLine("linked List is empty");
                return ;
            }
            while(temp != null)
            {
                Console.WriteLine(temp.data+" ");
                temp=temp.next;
                count++;
            }
            Console.WriteLine("length of LinkedList is : " + " " + count);
        }


        public void Display()
        {
            Console.WriteLine("\n========Display Nodes========\n");
            Node temp=this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked List is empty!");
                return;
                
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data +"");
                temp = temp.next;
            }
        }
    }
}
