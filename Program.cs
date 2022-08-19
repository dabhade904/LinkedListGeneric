using System.Collections.Generic;

namespace LinkedListGeneric
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome Message");
            LinkedList<int> list = new LinkedList<int>();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.Display();
            list.Append(30);
            list.Display();
            Console.WriteLine("After Deleted first Position");
            list.RemoveFirstNode();
            list.Display();
        }
    }
}