using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift3
{
    internal class Person
    {
        private int _age;
        private string _fName;
        private string _lName;
        public int Age {
            get { return _age; }
            set {
                if(value > 0) _age = value;
            }
        }
        public string fName { get; set; }
        public string lName { get; set; }
        public int Height { get; set; }
        public int Weight { get; set; }




    }
}
