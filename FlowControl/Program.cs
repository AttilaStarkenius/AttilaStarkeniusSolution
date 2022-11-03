using System;

namespace FlowControl
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /*3.11.2022.If the user chooses to exit the program, 
                the MainMenu() method returns a false value*/
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }
        private static bool MainMenu()
        {
            /*3.11.2022. Based on
             what option user chooses, 
            the program will call the appropriate method.*/
            bool continueProgram = true;
            while (continueProgram)
            {
                Console.Clear();
                Console.WriteLine("Welcome to main menu," +
                    "please choose an option by writing a number:");
                Console.WriteLine("Choose an option:");
                Console.WriteLine("1) Buy adolescent or pensioner movie ticket");
                Console.WriteLine("2) Buy group movie ticket");
                Console.WriteLine("3) See your input repeated 10 times");
                Console.WriteLine("4) See output of the third word of a sentence you write");

                //Console.Write("\r\nSelect an option: ");

                string menu = Console.ReadLine();


                switch (menu)
                {
                    case "0":
                        Environment.Exit(0);
                        break;

                    case "1":
                        /* check the boolean condition */
                        Console.WriteLine("Please write your age in numbers: ");
                        int intTemp = Convert.ToInt32(Console.ReadLine());

                        if (intTemp < 20)
                        {
                            Console.WriteLine("Adolescent price: 80 Swedish kronas");

                            ///* if condition is true then check the following */
                            //if (b == 200)
                            //{
                            //    /* if condition is true then print the following */
                            //    Console.WriteLine("Value of a is 100 and b is 200");
                            //}
                        }
                        else if (intTemp > 64)
                        {
                            Console.WriteLine("Pensioner price: 90 Swedish kronas");

                        }
                        else
                        {
                            Console.WriteLine("Standard price: 120 Swedish kronas");
                        }
                        break;

                    case "2":
                        Console.WriteLine("For how many persons do you want to buy a movie ticket?");
                        int intTemp2 = Convert.ToInt32(Console.ReadLine());
                        int i = 0;
                        int age = 0;
                        int totalsum = 0;

                        while (i < intTemp2)
                        {
                            Console.WriteLine("Please write your ages in numbers: ");
                            age = Convert.ToInt32(Console.ReadLine());
                            //int totalsum = 0;
                            if (age < 20)
                            {
                                totalsum += 80;

                                ///* if condition is true then check the following */
                                //if (b == 200)
                                //{
                                //    /* if condition is true then print the following */
                                //    Console.WriteLine("Value of a is 100 and b is 200");
                                //}
                            }
                            else if (age > 64)
                            {

                                totalsum += 90;

                            }
                            else
                            {

                                totalsum += 120;
                            }
                        }

                        Console.WriteLine("Number of people buying the movie ticket: "
                            + intTemp2);

                        Console.WriteLine("Total price for all the people buying the movie ticket: "
                            + totalsum);

                        //Console.WriteLine("Please write your ages in numbers: ");

                        break;

                    case "3":
                        //Console.WriteLine("Write at least 3 words, each words separated by a space");
                        Console.WriteLine("Write a word to repeat 10 times");
                        string stringTemp = (Console.ReadLine());

                        //string[] words = stringTemp.Split(' ');

                        //int i2 = 0;
                        for (int i2 = 0; i2 < 10; i2++)
                        {

                            Console.Write(stringTemp);

                        }
                        break;

                    case "4":
                        Console.WriteLine("Write at least 3 words, each words separated by a space");
                        string stringTemp2 = (Console.ReadLine());

                        string[] words = stringTemp2.Split(' ');
                        Console.WriteLine(words[2]);
                        break;

                    default:
                        throw new ArgumentException("Only numbers are accepted for input");
                        //break;
                }
            }

            bool notExitedProgram = true;
            while (notExitedProgram)
            {
                Console.WriteLine("Not exited program");
                //bool = false;
            }

            return true;
            ///* check the boolean condition */
            //if (a == 100)
            //{

            //    /* if condition is true then check the following */
            //    if (b == 200)
            //    {
            //        /* if condition is true then print the following */
            //        Console.WriteLine("Value of a is 100 and b is 200");
            //    }
            //}
        }
    }
}