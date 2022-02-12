using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class LinkedListStack
    {
        private Node top;
        public LinkedListStack()
        {
            top = null;
        }
        public void Push(int data)
        {
            Node node = new Node(data);
            if(top == null)
            {
                node.next = null;
            }
            else
            {
                node.next = top;
            }
            top = node;
            Console.WriteLine("{0} Pushed into Stack",data);
        }

        public void Peek()
        {
            if(top == null)
            {
                Console.WriteLine("Stack is empty!");
                return;
            }
            Console.WriteLine("{0} is the Top of the stack",top.data);
        }

        public void Pop()
        {
            if(top == null)
            {
                Console.WriteLine("Stack is empty,Deletion is not possible");
                return ;
            }
            Console.WriteLine("Data Popped is {0}",top.data);
            top = top.next;
        }

        public void IsEmpty()
        {
            while(top != null)
            {
                Peek();
                Pop();
            }
        }

        public void Display()
        {
            Console.WriteLine("\n========Display Stack========\n");
            Node temp=top;
            if (temp == null)
            {
                Console.WriteLine("Stack is empty!");
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
