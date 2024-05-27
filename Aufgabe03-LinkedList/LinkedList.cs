using System;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Aufgabe03_LinkedList
{
   public class LinkedList
    {
        Node[] array;
        int position = -1;

        public class Node
        {
            public string Value { get; set; }
            public Node Successor { get; set; }

            public Node(string value)
            {
                this.Value = value;
            }
        }

        public void Add(string value)
        {
            Node newValue = new Node(value);

            if (head != null)
            {
                newValue.Successor = head;
            }

            if (position + 1 == array.Length) ChangeArrayLength(array.Length * 2);
            array[++position] = value;
            head = newValue;        }

        public void AddLast(string value)
        {
            Node newValue = new Node(value);
            

            if(head == null)
            {
                head = newValue;
            }
            else
            {
                Node current = head;
                while(current.Successor != null)
                {
                    current = current.Successor;
                }

                current.Successor = newValue;

            }
        }
    }
}

