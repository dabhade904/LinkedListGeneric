using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace LinkedListGeneric
{
    public class LinkedList<T>
    {
        public Node<T> head;
        public void Add(T data)
        {
            Node<T> node = new Node<T>(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node <T>temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
        }

        public void Append(T data)
        {
            Node<T> node = new Node<T>(data);
            if (this.head == null)
                this.head = node;
            else
            {
                node.next = head;
                this.head = node;
            }
            Console.WriteLine("{0} inserted into the linked list", node.data);
        }

        public Node<T> RemoveFirstNode()
        {
            if (this.head == null)
                return null;
            Node<T> firstElement = this.head;
            this.head = this.head.next;
            return firstElement;
        }

        public Node<T> RemoveLastNode()
        {
            if (head == null)
                return null;
            if (head.next == null)
                return null;
            Node<T> newNode = head;

            while (newNode.next.next != null)
            {
                newNode = newNode.next;
            }
            Node<T> lastElement = newNode.next;
            newNode.next = null;
            return lastElement;
        }
        public void Display()
        {
            Node<T> temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked is empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.data + " ");
                temp = temp.next;
            }
        }
    }
}

