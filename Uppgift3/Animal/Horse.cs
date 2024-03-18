using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift3.Animal
{
    public class Horse : Animal
    {
        public double Height {  get; set; }
        public Horse(string name, double vikt, int age, double height) : base(name, vikt, age)
        {
            Height = height;
        }

        public override void DoSound()
        {
            Console.WriteLine("neigh,neigh");
        }

        public override string States()
        {
            return base.States() + $", Height:  {Height}";
        }
    }
}
