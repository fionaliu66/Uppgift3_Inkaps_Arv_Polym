using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift3
{
    public class Person
    {

        public Person(string fName, string lName)
        {
            FName = fName;
            LName = lName;
        }
        private int _age;
        private string _fName;
        private string _lName;
        public int Age
        {
            get { return _age; }
            set
            {
                if (value > 0) _age = value;
                else
                throw new ArgumentException("Age should be lager than 0", value.ToString());
            }
        }
        public string FName
        {
            get { return _fName; }
            set
            {
                if (value.Length >= 2 && value.Length <= 10) _fName = value;
                else
                throw new ArgumentException("First name should be longer than 2 character and shorter than 10 character", value.ToString());
                
            }
        }
        public string LName {
            get { return _lName; }
            set
            {
                if (value.Length >= 3 && value.Length <= 15) _fName = value;
                else
                throw new ArgumentException("Last name should be longer than 3 character and shorter than 15 character", value.ToString());

            }
        }
        public double Height { get; set; }
        public double Weight { get; set; }


        //Can do
        //Equals, toString

    }
}
