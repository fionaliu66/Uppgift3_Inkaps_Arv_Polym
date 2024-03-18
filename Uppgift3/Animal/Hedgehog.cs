using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift3.Animal
{
    public class Hedgehog : Animal
    {
        public int NrOfSpikes {  get; set; }
        public Hedgehog(string name, double vikt, int age, int nrOfSpikes) : base(name, vikt, age)
        {
            NrOfSpikes = nrOfSpikes;
        }

        public override void DoSound()
        {
            Console.WriteLine("Squeak,Squeak");
        }

        public override string States()
        {
            return base.States() + $", Number Of Spikes: {NrOfSpikes}";
        }
    }
}
