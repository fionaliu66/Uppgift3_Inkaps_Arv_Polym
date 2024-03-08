using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift3.Animal
{
    internal class Bird : Animal
    {
        public bool CanFly {  get; set; }
        public Bird(string name, double vikt, int age, bool canFly) : base(name, vikt, age)
        {
            CanFly = canFly;
        }

        public override void DoSound()
        {
            Console.WriteLine("Chirp, Chirp");
        }
    }
}
