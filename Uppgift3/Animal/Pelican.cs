using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift3.Animal
{
    public class Pelican : Bird
    {
        public double BeakLength {  get; set; }
        public Pelican(string name, double vikt, int age, bool canFly, double beakLength) : base(name, vikt, age, canFly)
        {
            BeakLength = beakLength;
        }
    }
}
