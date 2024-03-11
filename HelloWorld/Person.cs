using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Person
    {
        string _name;
        string _city;
        int _age;

        public Person(string name, string city, int age)
        {
            _name = name;
            _city = city;
            _age = age;
        }

        public string Info()
        {
            return $"Name: {_name}, City: {_city}, Age: {_age}";
        }
    }
}
