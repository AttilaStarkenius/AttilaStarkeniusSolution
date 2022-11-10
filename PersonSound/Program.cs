using System.Diagnostics;
using System.Xml.Linq;

namespace PersonSound
{
    public class Program
    {
        public static void Main(string[] args)
        {
            List<Animal> Animals = new List<Animal>();
            Animals.Add(new Dog("Tom", 30, 10));
            Animals.Add(new Horse("Harry", 240, 12));
            Animals.Add(new HedgeHog("James", 1, 4));
            //Animals.Add(new Person(31, "Andy", "Sumner", 179, 78));

            foreach (var item in Animals)
            {
                Console.WriteLine("Name: " + item.Name + " Weight: " +
                    item.Weight + " Age: " + item.Age);
                Wolf wolf = new Wolf("Wolf", 100, 10);
                wolf.DoSound();

                if (item is IPerson myObj)
                {
                    Person person = new Person(31, "Andy", "Sumner", 179, 78);
                    person.Talk();
                }

                //if (typeof(IPerson).IsAssignableFrom(item.GetType()))
                //{
                //}                //Animal.DoSound();
            }

            List<Dog> dogs = new List<Dog>();
            //I cannot add a horse
            //to a list of dogs called "dogs": dogs.Add(new Horse("Gerarld", 350, 14));
            //cannot convert type Horse to type Dog - they are different
            //types, even though both inherit the Animal.cs class.
            //The list has to be of type "Animal" to be able to include
            //different animals in a same list.

            foreach (var item in Animals)
            {
                //Wolf wolf = new Wolf("Wolf", 100, 10);
                //wolf.Stats(wolf);
                //11.10.2022. To access Stats() Method, I need instance
                //of animal and then call Stats through it  item.Stats(wolf);

                item.Stats(item);

                //11.10.2022. The class "Animal" does not
                //contain method "returnSomeString" so I can't access
                //Dog class' method "returnSomeString" because
                //this is list of Animals, not Dogs especially.
                //Only Animals' class methods are accessible
                //for a list of Animals so I can't do this: "item.returnSomeString();"

                //11.10.2022. So I try to access Dog method returnSomeString like this:
                //((Dog)Animals[0]).returnSomeString();
                ((Dog)Animals[0]).returnSomeString(); /*= "Boeing";*/

            }

            foreach (var item in dogs)
            {
                item.Stats(item);
            }

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