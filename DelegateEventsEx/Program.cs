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
            Console.ReadLine();
        }

        static int Sum(int x, int y) { return x + y; }
        static int Multiply(int x, int y) { return x * y; }
    }
}
