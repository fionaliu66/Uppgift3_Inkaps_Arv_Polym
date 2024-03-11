using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift3
{
    public class PersonHandler
    {
        private List<Person> personList = new List<Person>();
      
        public void SetAge(Person pers, int age)
        {
            pers.Age = age; 
        }
        public Person CreatePerson(int age, string fname,string lname, double height, double weight)
        {
            //if(string.IsNullOrEmpty(fname) || string.IsNullOrEmpty(lname))
            //{
            //    //Send message or throw exception
            //    Console.WriteLine(new NullInputError().UEMessage());
            //}
            Person p = new(fname,lname);
            p.Age = age;
            p.Height = height;
            p.Weight = weight;
            return p;
        }
        //other usefull methods

        public void AddPerson(Person p)
        {
            personList.Add(p);
        }
        public void RemovePerson(Person p)
        {
            personList.Remove(p);
        }
        public List<Person> GetPersonList() { 
            return personList; 
        }
        public Person GetPersonByName(string fName, string lName) {
            //Set up a defult value here
            Person p = CreatePerson(18,"Eva","Wang",170,50);
            if(string.IsNullOrEmpty(fName) || string.IsNullOrEmpty(lName))
            {
                Console.WriteLine(new NullInputError().UEMessage()); 
            }
            try
            {
                personList.Find(p => p.FName == fName && p.LName == lName);
            }catch(ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            return p;
        }

    }
}
