using System.Diagnostics;
using System.Xml.Linq;

namespace PersonSound
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*8.11.2022. I create an instance of Person class
                         Person person = new Person();
            I can access the properties of class Person.cs
            like this:  int age = person.Age;

             */


            //Person person = new Person();

            PersonHandler handler = new PersonHandler();

            handler.CreatePerson(31, "Attila", "Starkenius", 1.84, 75);
            handler.CreatePerson(37, "Medel", "Svensson", 1.84, 81);

                    List<UserError> UserErrorList = new List<UserError>();

            NumericInputError numInputError = new NumericInputError();
            //numInputError.UEMessage();
            UserErrorList.Add(numInputError);
            TextInputError textInputError = new TextInputError();
            UserErrorList.Add(textInputError);
            LessThanZeroError lessThanZeroError = new LessThanZeroError();
            UserErrorList.Add(lessThanZeroError);
            NoFirstNameError noFirstNameError = new NoFirstNameError();
            UserErrorList.Add(noFirstNameError);
            NoLastNameError noLastNameError = new NoLastNameError();
            UserErrorList.Add(noLastNameError);



            foreach (var item in UserErrorList)
            {
                if(item == numInputError)
                Console.WriteLine("“You tried to use a numeric input in a text only field. This fired an error!”");
                if (item == textInputError)
                Console.WriteLine("“You tried to use a text input in a numeric only field. This fired an error!”");
                if (item == lessThanZeroError)
                    Console.WriteLine("“You have entered value less than 0 in Age field. This fired an error!”");
                if(item == noFirstNameError)
                    Console.WriteLine("“You have not written any first name in FName field. This fired an error!”");
                if (item == noLastNameError)
                    Console.WriteLine("“You have not written any last name in LName field. This fired an error!”");

            }


            //UserErrorList.
        }

        //int age = person.Age;

        //Console.WriteLine("Hello, World!");

        public void AddPersonAge(Person person)
        {
            try
            {
                if (person.Age <= 0)
                    throw new ArgumentException($"Provided age {person.Age} has to be a number greater than 0.");
                // throws if something is wrong
                //Children.Add(childStructureLevel);
            }
            catch (ArgumentException ae)
            {
                throw new ArgumentException($"Provided age {person.Age} has to be a number greater than 0.", ae);
            }

            //Trace.WriteLine($"Added new child structure level to parent structure children.");
        }

        public void AddPersonFName(Person person)
        {
            try
            {
                if (person.FName.Length < 2 && person.FName.Length > 10)
                    throw new ArgumentException($"Provided first name {person.FName} has to be a number between 2 and 10.");
                // throws if something is wrong
                //Children.Add(childStructureLevel);
            }
            catch (ArgumentException ae)
            {
                throw new ArgumentException($"Provided first name {person.FName} has to be a number between 2 and 10.", ae);
            }

            //Trace.WriteLine($"Added new child structure level to parent structure children.");
        }


        public void AddPersonLName(Person person)
        {
            try
            {
                if (person.LName.Length < 3 && person.LName.Length > 15)
                    throw new ArgumentException($"Provided last name {person.LName} has to be a number between 3 and 15.");
                // throws if something is wrong
                //Children.Add(childStructureLevel);
            }
            catch (ArgumentException ae)
            {
                throw new ArgumentException($"Provided last name {person.LName} has to be a number between 3 and 15.");
            }

            //Trace.WriteLine($"Added new child structure level to parent structure children.");
        }
        //public void TryPassAgeValidation(Person person)
        //{
        //    TryPassingStructureNameMinMaxLength(person.FName);
        //    TryPassingStructureNameMinMaxLength(person.LName);
        //}

        //public void TryPassingStructureNameMinMaxLength(string structureName)
        //{
        //    bool nameIsTooLong = structureName.Length >= maxLengthStructureName;
        //    bool nameIsTooShort = structureName.Length <= minLengthStructureName;

        //    if (nameIsTooLong) throw new ArgumentException($"Structure name is too long. Max {maxLengthStructureName} characters.");
        //    if (nameIsTooShort) throw new ArgumentException($"Structure name is too short. Min {minLengthStructureName} characters.");
        //}

        //private void TryPassingStructureNameUnique(string childName)
        //{
        //    foreach (Structure child in Children) //TODO: recurse over children.children
        //        if (child.Name == childName) throw new ArgumentException($"Structure level name {childName} already exists.");
        //}
    }
}