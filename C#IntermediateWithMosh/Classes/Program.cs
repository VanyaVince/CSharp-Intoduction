using System;


namespace Classes
{
    public class Person
    {
        public String Name;

        public void Introduce(string to)
        {
            Console.WriteLine($"Hi {to}, my Name is {Name}");
        }

        public static Person Parse(string name)
        {
            Person person = new Person();
            person.Name = name;
            return person;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Vince";
            person.Introduce("Vanya");

            var person1 = Person.Parse("Vince");
            person1.Introduce("Vanya");
        }
    }
}
