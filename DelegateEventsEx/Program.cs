using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateEventsEx
{
    internal class Program
    {
        public delegate int MyDelegate(int a, int b);
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Delegates,Events & Lambda");
            MyDelegate myDelegate = Sum;
            Console.WriteLine(myDelegate(10, 20));
            myDelegate = Multiply;
            Console.WriteLine(myDelegate(10, 20));

            MyDelegate myDelegate1 = Sum,myDelegate2 = Multiply;
            MyDelegate myDelegate3 = myDelegate1 + myDelegate2; // Chaining of delegates
            Console.WriteLine(myDelegate3(20, 30));

            PublisherClass objPublish = new PublisherClass();
            //Step 3:  Define an Event Handler that respond when event raised.
            objPublish.ValueChanged += new PublisherClass.ValueChangedEventHandler(EventMessage);

            objPublish.PrintName("deepak");

            Console.ReadLine();
        }

        // Step 4 You must have method ready for delegates.
        static void EventMessage(string a) 
        {
            Console.WriteLine("The changed value is {0}",a);
        }

        static int Sum(int x, int y) { return x + y; }
        static int Multiply(int x, int y) { return x * y; }
    }

    /// <summary>
    /// Step 1: Define a Delegate
    //  Step 2: Define an Event with same name of Delegates.
    /// Step 3: Define an Event Handler that respond when event raised.
    /// Step 4: You must have method ready for delegates.
    /// </summary>
    public class PublisherClass
    {
        // Step 1 Define a Delegate
        public delegate void ValueChangedEventHandler(string val);

        // Step 2 Define an Event with same name of Delegates.
        public event ValueChangedEventHandler ValueChanged; 

        public void PrintName(string name) 
        {
            Console.WriteLine("The value is : " + name);
            ValueChanged(name);
        }


    }
}
