using System;
using System.Xml.Linq;

namespace Aufgabe03_LinkedList
{
   public class LinkedList
    {
        Node head;

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

        // Indexer zum Zugreifen auf Elemente basierend auf ihrem Index
        public string this[int index]
        {
            get
            {
                if (index < 0) throw new IndexOutOfRangeException("Index darf nicht negativ sein.");
                Node current = head;
                int currentIndex = 0;

                while (current != null)
                {
                    if (currentIndex == index)
                    {
                        return current.Value;
                    }
                    current = current.Successor;
                    currentIndex++;
                }

                throw new IndexOutOfRangeException("Index liegt außerhalb der Grenzen der Liste.");
            }
            set
            {
                if (index < 0) throw new IndexOutOfRangeException("Index darf nicht negativ sein.");
                Node current = head;
                int currentIndex = 0;

                while (current != null)
                {
                    if (currentIndex == index)
                    {
                        current.Value = value;
                        return;
                    }
                    current = current.Successor;
                    currentIndex++;
                }

                throw new IndexOutOfRangeException("Index liegt außerhalb der Grenzen der Liste.");
            }
        }
    }
}

