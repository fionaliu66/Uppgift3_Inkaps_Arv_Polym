using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift3.Animal
{
    internal class Wolfman : Wolf, IPerson
    {
        public Wolfman(string name, double vikt, int age, double furLength) : base(name, vikt, age, furLength)
        {
        }

        public string Talk()
        {
            return "Finally, the full moon has arrived.";
        }
    }
}
