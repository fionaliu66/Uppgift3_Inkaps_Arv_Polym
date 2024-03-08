using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift3.Animal
{
    internal class Wolfman : Wolf, IPerson
    {
        public double Height {  get; set; }
        public Wolfman(string name, double vikt, int age, double furLength, double height) : base(name, vikt, age, furLength)
        {
            Height = height;    
        }

        public string Talk()
        {
            return "Finally, the full moon has arrived.";
        }

        public override string States()
        {
            return $"Name: {Name}, Viket: {Vikt}, Age: {Age}, FurLength:  {FurLength}, Height: {Height}";
        }
    }
}
