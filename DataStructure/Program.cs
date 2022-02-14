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
            Console.WriteLine("Welcome to Queue Operations \n");
            LinkedListQueue list = new LinkedListQueue();
            list.Enqueue(70);
            list.Enqueue(30);
            list.Enqueue(56);
            list.Display();
            list.Dequeue();
            list.Display();
            
                   
        }
    }
}
