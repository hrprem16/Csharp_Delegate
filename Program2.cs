//Lambda expressions in C# are used like anonymous functions, with the difference that in Lambda expressions you don’t need to specify the type of the value that you input thus making it more flexible to use. 
//The ‘=>’ is the lambda operator which is used in all lambda expressions. The Lambda expression is divided into two parts, the left side is the input and the right is the expression.

//The Lambda Expressions can be of two types: 
// using System.Linq;
//->> THe lamda expression can be of two type
//->Expression Lambda: Consists of the input and the expression.
//Syntax:
//input => expression;
//Statement Lambda: Consists of the input and a set of statements to be executed.
//Syntax:
// input => { statements };
//Let us take some examples to understand the above concept better.

/*Example 1: In the code given below, we have a list of integer numbers. The first lambda expression evaluates every element’s square { x => x*x } and the second is used to find which values are divisible by 3 { x => (x % 3) == 0 }. And the foreach loops are used for displaying. */

using System;
using System.Collections.Generic;
using System.Linq;

namespace Lambda_Expressions
{
    class Program
    {
        class Student
        {

            // properties rollNo and name
            public int rollNo
            {
                get;
                set;
            }

            public string name
            {
                get;
                set;
            }
        }
        static void Main(string[] args)
        {
            //List to store number

            List<int> numbers = new List<int>()
            { 36,71,12,15,29,18,27,17,9,34};

            Console.WriteLine("The List : ");
            foreach (var value in numbers)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine("Square of element: ");
            // Using lambda expression
            // to calculate square of
            // each value in the list
            var sqaure = numbers.Select(x => x * x);
            foreach (var value in sqaure)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();

            // Using Lambda expression to
            // find all numbers in the list
            // divisible by 3

            List<int> divBy3 = numbers.FindAll(x => (x % 3) == 0);

            Console.Write("Numbers divisble by 3: ");
            foreach(var value in divBy3)
            {
                Console.Write(value + " ");
            }
            Console.WriteLine();

            // List with each element of type Student
            List<Student> details = new List<Student>() {
            new Student{ rollNo = 1, name = "Liza" },
                new Student{ rollNo = 2, name = "Stewart" },
                new Student{ rollNo = 3, name = "Tina" },
                new Student{ rollNo = 4, name = "Stefani" },
                new Student { rollNo = 5, name = "Trish" }
             };

            // To sort the details list 
            // based on name of student
            // in ascending order
            var newDetails = details.OrderBy(x => x.name);

            foreach (var value in newDetails)
            {
                Console.WriteLine(value.rollNo + " " + value.name);
            }

        }
    }
}





// Delegate Basic
/*using System;  
delegate int Calculator(int n);//declaring delegate  
      
public class DelegateExample  
{  
    static int number = 100;  
    public static int add(int n)  
    {  
        number = number + n;  
        return number;  
    }  
    public static int mul(int n)  
    {  
        number = number * n;  
        return number;  
    }  
    public static int getNumber()  
    {  
        return number;  
    }  
    public static void Main(string[] args)  
    {  
        Calculator c1 = new Calculator(add);//instantiating delegate  
        Calculator c2 = new Calculator(mul);  
        c1(20);//calling method using delegate  
        Console.WriteLine("After c1 delegate, Number is: " + getNumber());  
        c2(3);  
        Console.WriteLine("After c2 delegate, Number is: " + getNumber());  
  
    }  
}  

*/
