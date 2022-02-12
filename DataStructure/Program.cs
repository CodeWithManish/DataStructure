using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructure
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Stack Operations \n");
            LinkedListStack list = new LinkedListStack();
            list.Push(70);
            list.Push(30);
            list.Push(56);
            list.Display();
            /*list.Peek();
            list.Pop();*/
             list.IsEmpty();
            list.Display();
                   
        }
    }
}
