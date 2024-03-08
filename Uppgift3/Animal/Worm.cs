using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift3.Animal
{
    public class Worm : Animal
    {
        public bool IsHerbivore {  get; set; }
        public Worm(string name, double vikt, int age, bool isHerbivore) : base(name, vikt, age)
        {
            IsHerbivore = isHerbivore;
        }

        public override void DoSound()
        {
            Console.WriteLine("Squirm,Squirm");
        }
    }
}
