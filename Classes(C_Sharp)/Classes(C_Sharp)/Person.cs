using System;

namespace Classes_C_Sharp_
{
    public class Person
    {
        public String firstName;
        public String lastName;

        public void Introduce()
        {
            Console.WriteLine("Hi, it's " + firstName + " " + lastName);
        } 
    };
}
