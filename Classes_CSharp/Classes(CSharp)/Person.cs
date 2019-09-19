using System;


namespace Classes_CSharp_
{
    public class Person
    {
        public String firstName;
        public String lastName;

        public void Introduce(int age)
        {
            Console.WriteLine("Hi, it's " + firstName + " " + lastName + ". I'm" + " " + age + " years old");
        }
    };
}
