using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift3.Animal
{
    public abstract class Animal(string name, double vikt, int age)
    {
        public string Name { get; set; } = name;
        public double Vikt { get; set; } = vikt;

        public int Age { get; set; } = age;

        public abstract void DoSound();

        public virtual string States()
        {
            return $"Name: {Name}, Viket: {Vikt}, Age: {Age}";
        }

        
    }
}
