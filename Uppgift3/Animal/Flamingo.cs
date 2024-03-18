using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift3.Animal
{
    public class Flamingo : Bird
    {
        public double legLength {  get; set; }  
        public Flamingo(string name, double vikt, int age, bool canFly, double legLength) : base(name, vikt, age, canFly)
        {
            this.legLength = legLength;
        }

        public override string States()
        {
            return base.States() + $", LegLength: {legLength}";
        }
    }
}
