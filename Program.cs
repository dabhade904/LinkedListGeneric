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
            list.Append(30);
            list.Display();
            list.Add(70);
            list.Display();
          
        }
    }
}