using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace PersonSound
{
    public class PersonHandler
    {
        public List<Person> PersonList = new List<Person>();

        public Person CreatePerson(int age, string fname, string lname, double height, double weight)
        {
            PersonList.Add(new Person(age, fname, lname, height, weight));
            return new Person(age, fname, lname, height, weight);
            
            //    Age = age;
            //FName = fname;
            //LName = lname;
            //Height = height;
            //Weight = weight; 
        
        }

        public void RemovePerson(int age, string fname, string lname, double height, double weight)
        {
            int i = 0;
            while (i < PersonList.Count)
            {
                Person currentPerson = PersonList[i];
                if (currentPerson.Age == age && currentPerson.FName == fname
                    && currentPerson.LName == lname && currentPerson.Height == height
                    && currentPerson.Weight == weight)
                {
                    PersonList.RemoveAt(i);
                }
                else
                {
                    i++;
                }
            }
            //PersonList.Remove(new Person(age, fname, lname, height, weight));
            //return new Person(age, fname, lname, height, weight);

            //    Age = age;
            //FName = fname;
            //LName = lname;
            //Height = height;
            //Weight = weight; 

        }

    }
    }
            //Person person = new Person();
            //person.Age = age;
            //person.FName = fname;
            //person.LName = lname;   
            //person.Height = height;
            //person.Weight = weight;
            //return new Person();
        
    

