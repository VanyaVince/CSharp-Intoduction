using System;
using System.Collections.Generic;
using System.Runtime.Remoting.Channels;

namespace Classes
{
    public class Person
    {
        public String Name;
        public int Age;
        public readonly List<Orders> Orders = new List<Orders>();

        public Person()
        {
        }
        public Person(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }
        public static Person Parse(string name)
        {
            Person person = new Person();
            person.Name = name;
            return person;
        }
        public void Introduce(string to)
        {
            Console.WriteLine($"Hi {to}, my Name is {Name}");
        }

        public void ShowYears(params int [] years)
        {
            Console.Write("The years when you got a champion ");
            for (int i = 0; i < years.Length; i++)
                Console.Write(years[i] + " ");
            Console.WriteLine();
        }

        public static void Initialize(out int a)
        {
            a = 25;
        }

        public override string ToString()
        {
            return $"This is {this.Name}, {this.Age} years old";
        }
    }
}