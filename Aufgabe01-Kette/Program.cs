using System.Collections.Generic;

namespace Aufgabe01_Kette;

class Program
{
    static void Main(string[] args)
    {
        Kette person = new Kette();

        person.AddPerson(new Person("John Doe", 30, 80.90, 190.8));
        person.AddPerson(new Person("Max Müller", 23, 70.50, 170.5));
        person.AddPerson(new Person("Tom Smith", 89, 68.77, 168.9));

        person.PrintAll();
    }
}

