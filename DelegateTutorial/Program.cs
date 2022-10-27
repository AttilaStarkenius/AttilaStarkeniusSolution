using System;

namespace DelegateTutorial
{
    //public delegate void MyDelegate(string msg);
    public delegate void MyDelegate(string msg); // declare a delegate


    public class Program
    {
        // set target method
        //MyDelegate del = new MyDelegate(MethodA);
        // or 
        //MyDelegate del = MethodA;
        //// or set lambda expression 
        //MyDelegate del = (string msg) => Console.WriteLine(msg);

        // target method
        //        static void MethodA(string message)
        //        {
        //            Console.WriteLine(message);
        //        }

        //        del.Invoke("Hello World!");
        //// or 
        //del("Hello World!");

        // Create a method for a delegate.
        //public static void DelegateMethod(string message)
        //{
        //    Console.WriteLine(message);
        //}
        // Instantiate the delegate.
        //delegate handler = DelegateMethod;
        /*25.10.2022         Delegate handler = DelegateMethod;
         gives me error Severity	Code	Description	Project	File	Line	Suppression State
Error	CS0428	Cannot convert method group 'DelegateMethod' to non-delegate type 'Delegate'. Did you intend to invoke the method?	DelegateTutorial	C:\Users\symph\source\repos\AttilaStarkeniusSolution\DelegateTutorial\Program.cs	13	Active
I change tutorial to: https://www.tutorialsteacher.com/csharp/csharp-delegates
        like this: "The following declares a delegate named MyDelegate.

Example: Declare a Delegate
public delegate void MyDelegate(string msg);"
27.10.2022. I commit and push to Git Changes with message:
        "27.10.2022. Doing tutorial https://www.tutorialsteacher.com/csharp/csharp-delegates"
*/





        // Call the delegate.
        //handler("Hello World");
        public static void Main(string[] args)
        {
            MyDelegate del = ClassA.MethodA;
            del("Hello World");

            del = ClassB.MethodB;
            del("Hello World");

            del = (string msg) => Console.WriteLine("Called lambda expression: " + msg);
            del("Hello World");
            //Console.WriteLine("Hello World!");
        }
    }
}
public class ClassA
{
    public static void MethodA(string message)
    {
        Console.WriteLine("Called ClassA.MethodA() with parameter: " + message);
    }
}

public class ClassB
{
    public static void MethodB(string message)
    {
        Console.WriteLine("Called ClassB.MethodB() with parameter: " + message);
    }
}
/*27.10.2022. I create a console application project
 called "DelegateTutorial", set DelegateTutorial as the startup project and I 
do the tutorial in this web
page: https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/delegates/using-delegates*/