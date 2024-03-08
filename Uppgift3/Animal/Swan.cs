using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift3.Animal
{
    public class Swan : Bird
    {
        public double NeckLength {  get; set; }
        public Swan(string name, double vikt, int age, bool canFly, double neckLength) : base(name, vikt, age, canFly)
        {
            NeckLength = neckLength;
        }

        public override string States()
        {
            return $"Name: {Name}, Viket: {Vikt}, Age: {Age}, CanFLy ? {CanFly}, NeckLength: {NeckLength}";
        }
    }
}
