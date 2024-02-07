using System;
public delegate void MyDelegate(string message);

class Program
{
    static void Main()
    {
        MyDelegate delegateInstance = new MyDelegate(DisplayMessage);

        delegateInstance("Hello, Delegates");

        MyDelegate anotherdeletegateInstance = new MyDelegate(DisplayAnother);
        anotherdeletegateInstance("delegate are powerful");

        // Multicast delegate : combining multiple methods
        MyDelegate multidelegate = DisplayMessage;
        multidelegate += anotherdeletegateInstance;

        // Invoke all methods in the muslitcast delegate
        multidelegate("combined delegate");

        // Remove a method from the multicast delegate

        multidelegate -= DisplayMessage;
        multidelegate("After removing a method");

        // Using bulit-in Action delegate

        Action<string> actionDelegate = DisplayMessage;
        actionDelegate("USING ACTION DELEGATE");

        //using built-in function delegate with return type

        Func<int, int,int> addDelegate = AddNumber;
        Console.WriteLine("sum: " + addDelegate(5, 7));





    }
    static void DisplayMessage(string message)
    {
        Console.WriteLine("Message" + message);
    }
    static void DisplayAnother(string message)
    {
        Console.WriteLine("Another" + message);
    }
    static int AddNumber(int a, int b)
    {
        return a + b;
    }
}
