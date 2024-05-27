using System;
namespace Aufgabe01_Kette
{
	public class Person
	{
        public string Name { get; set; }
        public int Age { get; set; }
        public double Weight { get; set; }
        public double Hight { get; set; }

        public Person(string name, int age, double weight, double hight)
		{
			this.Name = name;
			this.Age = age;
			this.Weight = weight;
			this.Hight = hight;
		}

        public override string ToString()
        {
            return $"Name: {this.Name} Age: {this.Age} Gewicht: {this.Weight} Größe: {this.Hight}\n";
        }
    }
}

