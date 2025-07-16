using System;

namespace MyFirstProgram // similar to package name in Java
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello\a, World!"); 
                 // or write , write line will create a new line
            Console.ReadKey(); 
                //use it at the end of the program to pause the console 
                //removes the ending statements
            double num1 = 5.123;
            int num2 = Convert.ToInt32(num1);
            //converts double to int, truncating the decimal part
        }
    }
}