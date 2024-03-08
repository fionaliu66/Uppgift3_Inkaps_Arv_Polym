using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift3.Animal
{
    public class Wolf : Animal
    {
        public double FurLength {  get; set; }
        public Wolf(string name, double vikt, int age, double furLength) : base(name, vikt, age)
        {
            FurLength = furLength;
        }

        public override void DoSound()
        {
            Console.WriteLine("Awoo,Howl");
        }
    }
}
