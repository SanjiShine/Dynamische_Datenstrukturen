using System;
using System.Text;
using System.Xml.Linq;

namespace Aufgabe04_Personenliste
{
    public class Personenliste
    {
        Person head;
        Person tail;

        public class Person
        {

            public string Name { get; set; }
            public Person Successor { get; set; }
            public Person Predecessor { get; set; }

            public Person(string name)
            {
                this.Name = name;
            }

            public override string ToString()
            {
                return this.Name;
            }
        }

        public void AddEnd(string name)
        {
            Person newPerson = new Person(name);

            if (tail == null)
            {
                head = newPerson;
                tail = newPerson;
            }
            else
            {
                tail.Successor = newPerson;
                newPerson.Predecessor = tail;
                tail = newPerson;
            }
        }

        public void AddFront(string name)
        {
            Person newPerson = new Person(name);

            if(head == null)
            {
                head = newPerson;
                tail = newPerson;
            }
            else
            {
                head.Predecessor = newPerson;
                newPerson.Successor = head;
                head = newPerson;
            }
        }

        public void AddSorted(string name)
        {
            Person newPerson = new Person(name);

            if(head == null)
            {
                head = newPerson;
                tail = newPerson;

            } else if (string.Compare(name, head.Name) <= 0)
            {
                AddFront(name);

            } else if (string.Compare(name,tail.Name) >= 0)
            {
                AddEnd(name);
            }
            else
            {
                Person current = head;
                while (current != null && string.Compare(name, current.Name) > 0)
                {
                    current = current.Successor;
                }

                newPerson.Successor = current;
                newPerson.Predecessor = current.Predecessor;
                current.Predecessor.Successor = newPerson;
                current.Predecessor = newPerson;
            }
        }

        public void DeleteFirst()
        {
            if (head == null) return;  // Leere Liste

            if(head == tail) // nur einen Beitrag
            {
                head = null;
                tail = null;
            }
            else
            {
                head = head.Successor; // 
                head.Predecessor = null; 
            }
        }

        public void DeleteLast()
        {
            if (tail == null) return;  // Leere Liste

            if (head == tail) // nur einen Beitrag
            {
                head = null;
                tail = null;
            }
            else
            {
                tail = tail.Predecessor; // 
                tail.Successor = null;
            }
        }

        public void DeleteByName(string name)
        {
            if (head == null) return;

            if(head.Name == name)
            {
                DeleteFirst();
                return;
            }

            if(tail.Name == name)
            {
                DeleteLast();
                return;
            }

            Person current = head;
            while(current != null && current.Name != name)
            {
                current = current.Successor;
            }

            if(current != null)
            {
                current.Predecessor.Successor = current.Successor;
                if(current.Successor != null)
                {
                    current.Successor.Predecessor = current.Predecessor;
                }
            }
        }

        public void Print()
        {
            Person current = head;
            while (current != null)
            {
                Console.WriteLine(current);
                current = current.Successor;
            }
            Console.WriteLine();
        }


        public void PrintReverse()
        {
            Person current = tail;
            while (current != null)
            {
                Console.WriteLine(current.Name);
                current = current.Predecessor;
            }
            Console.WriteLine();
        }

        public void PrintAll()
        {   
            Person current = head;

            while (current != null)
            {
                string precursor = current.Predecessor?.ToString() ?? "null";
                string successor = current.Successor?.ToString() ?? "null";

                Console.WriteLine($"Name: {current}, Vorgänger: {precursor}, Nachfolger: {successor}"); 
                current = current.Successor;
            }

            Console.WriteLine();
        }
    }
}

