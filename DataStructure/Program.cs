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
            Console.WriteLine("Welcome to Linked List Operations \n");
            LinkedList list = new LinkedList();
            list.Add(56);
            list.Add(30);
            list.Add(70);

            /*list.AddInReverseOrder(70);
            list.AddInReverseOrder(30);
            list.AddInReverseOrder(56);*/

             list.DeleteFirstNode(56);

              list.DeleteLastNode(70);

            int pos = list.Search(50);
            if(pos == -1)
            {
                Console.WriteLine("Element is not Present in the List");
            }
            else
            {
                Console.WriteLine(pos);
            }
            list.DeleteNodeAtParticularPosition(pos);
            list.Display();
            list.Size();
            Console.ReadKey();
        }
    }
}
