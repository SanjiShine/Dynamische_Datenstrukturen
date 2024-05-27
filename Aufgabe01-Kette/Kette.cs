using System;
using System.Text;

namespace Aufgabe01_Kette
{
    public class Kette
    {
        Element head;

        private class Element
        {
            public Element Successor { get; set; }
            public Person Person { get; set; }

            public Element(Person person)
            {
                this.Person = person;
            }
        }

        public void AddPerson(Person person)
        {
            Element newPerson = new Element(person);
            newPerson.Successor = head;
            head = newPerson;  
        }
        
        public void PrintAll()
        {
            Element currentElement = head;

            while (currentElement != null)
            {
                Console.WriteLine(currentElement.Person);
                currentElement = currentElement.Successor;
            }
        }

    }
}

