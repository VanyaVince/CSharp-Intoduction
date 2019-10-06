using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace PropertiesAndDictionary
{
    public class School
    {
        public int Number { get; set; }
        private readonly Dictionary<string, string> _teachers;

        public School()
        {
            _teachers = new Dictionary<string, string>();
        }

        public School(int number)
            : this()
        {
            this.Number = number;
        }

        public string this[string key]
        {
            get { return _teachers[key];}
            set { _teachers[key] = value; }
        }

        public void ReadAllTeachers()
        {
            foreach (var teacher in _teachers)
                Console.WriteLine(teacher);
        }
    }
}