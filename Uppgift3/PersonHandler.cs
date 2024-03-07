using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift3
{
    public class PersonHandler
    {
        private List<Person> persons;
        public PersonHandler() { 
        persons = new List<Person>();  
        }  
        public void SetAge(Person pers, int age)
        {
            pers.Age = age; 
        }
        public Person CreatePerson(int age, string fname,string lname, double height, double weight)
        {
            Person p = new(fname,lname);
            p.Age = age;
            p.Height = height;
            p.Weight = weight;
            return p;
        }
    }
}
