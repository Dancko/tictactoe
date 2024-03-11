using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    internal class Car
    {

        private string _name;
        private int _hp;
        private string _color;

        public Car(string name, int hp = 0, string color = "black")
        {
            _name = name;
            Console.WriteLine($"{name} was created.");
            _hp = hp;
            _color = color;
        }

        public void Drive()
        {
            Console.WriteLine($"{_name} is driving.");
        }

        public void Brake()
        {
            Console.WriteLine($"{_name} has stopped.");
        }

        public void Info()
        {
            Console.WriteLine($" Name: {_color} {_name}, HP: {_hp}");
        }

        public string Name { 
            get { return _name; }
            set { _name = value; } }


    }
}
