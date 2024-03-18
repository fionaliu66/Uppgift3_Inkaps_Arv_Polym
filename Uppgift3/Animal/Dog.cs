using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift3.Animal
{
    public class Dog : Animal
    {
        public string Breed {  get; set; }
        public Dog(string name, double vikt, int age, string breed) : base(name, vikt, age)
        {
            Breed = breed;  
        }

        public override void DoSound()
        {
            Console.WriteLine("woof,woof");
        }

        public override string States()
        {
            return base.States() + $", Breed:  {Breed}";
        }

        public string WeDogs()
        {
            return "Man's best friend";
        }
    }
}
