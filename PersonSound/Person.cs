using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonSound
{
    public class Person: IPerson
    {
        /*8.11.2022. I create a class called "Person" 
         with private fields: age, fName, lName, height, weight*/
        private int age;
        private string fName;
        private string lName;
        private double height;
        private double weight;

        public Person(int age, string fname, string lname, double height, double weight)
        {
            this.age = age;
            fName = fname;
            lName = lname;
            this.height = height;
            this.weight = weight;
        }

        /*8.11.2022. I create validation for Age like
         this: [Range(0, int.MaxValue, ErrorMessage = "Value Must Bigger Than {0}")]
        for FName like this: [Required(ErrorMessage = "FName is a required field.")]
        [StringLength(10, MinimumLength = 2)]
        and for LName like this: [Required(ErrorMessage = "LName is a required field.")]
        [StringLength(15, MinimumLength = 3)] 
        */
        [Range(0, int.MaxValue, ErrorMessage = "Value Must Bigger Than {0}")]
        public int Age { get; set; }

        [Required(ErrorMessage = "FName is a required field.")]
        [StringLength(10, MinimumLength = 2)]
        public string FName { get; set; }

        [Required(ErrorMessage = "LName is a required field.")]
        [StringLength(15, MinimumLength = 3)]
        public string LName { get; set; }   
        public double Height { get; set; }
        public double Weight { get; set; }

        public void Talk()
        {
            Console.WriteLine("A person says Hi!");
            //throw new NotImplementedException();
        }

        //public List<Person> PersonList = new List<Person>();

    }
}
