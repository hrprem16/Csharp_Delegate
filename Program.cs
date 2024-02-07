using System;
delegate int Calculator(int n);
namespace ConsoleApp2
{
    class DelegateExample
    {
        static int number=100;

        static int add(int n)
        {
            number =number+ n;
            return number;
        }
        static int mul(int n)
        {
            number = number * n;
            return number;
        }
        public static int  getnumber()
        {
            return number;
        }
        public static void Main(string[] args)
        {
            //In C#, delegate is a reference to the method. It works like function pointer in C and C++.
            //But it is objected-oriented, secured and type-safe than function pointer.

            // For static method, delegate encapsulates method only.But for instance method,
            // it encapsulates method and instance both.

            //Internally a delegate declaration defines a class which is the derived class of System.Delegate.
            Calculator c1 = new Calculator(add);
            Calculator c2 = new Calculator(mul);
            c1(20);
            
            Console.WriteLine(getnumber());
            c2(3);
            Console.WriteLine(getnumber());

        }
    }
}
