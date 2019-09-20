using System;

namespace Classes_CSharp_
{
    public class Person
    {
        public String firstName;
        public String lastName;

        public void Introduce(int age)
        {
            string info = String.Format("{0} {1} {2} {3} {4} {5}", "Hi, it's", firstName, lastName, "I'm", age, "years old");
            Console.WriteLine(info);
        }
        public static void StringJoinArray()
        {
            int count = 1;
            var numbers = new int[25];
            for (int i = 0; i < numbers.Length; i ++) 
            {
                numbers[i] = count;
                count += 1;
            }
            string list = string.Join(",", numbers);
            Console.WriteLine(list);
        }
    };
}
