using System;

namespace MyFirstProgram // similar to package name in Java
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello\a, World!"); 
                 // or write , write line will create a new line
            
                //use it at the end of the program to pause the console 
                //removes the ending statements
            double num1 = 5.123;
            int num2 = Convert.ToInt32(num1);
            //converts double to int, truncating the decimal part
            int c = 123;
            string c1 = Convert.ToString(c);

            Console.WriteLine(c1.GetType());
            // for output 

            Console.WriteLine("whats your name ?");
            String name = Console.ReadLine(); // to get input from user 
            Console.WriteLine("hello"+name+"have a great day!");

            // Math class
            int a = 5;
            int b = 10;
            int max = Math.Max(a, b); // returns the maximum of two numbers
            int min = Math.Min(a, b); // returns the minimum of two numbers 
            double sqrt = Math.Sqrt(25); // returns the square root of a number
            int abs = Math.Abs(-10); // returns the absolute value of a number
            double pow = Math.Pow(2, 3); // returns the power of a number (2^3 = 8)
            double round = Math.Round(5.6); // rounds a number to the nearest integer
            double roundDown = Math.Floor(5.6); // rounds down to the nearest integer
            double roundUp = Math.Ceiling(5.6); // rounds up to the nearest integer
            Console.WriteLine("Round: " + round);

            // Random class
            Random random = new Random(); // creates a new instance of the Random class
            int rn = random.Next(1, 100); // generates a random number between 1 and 100
            double rn2 = random.NextDouble();// generates a random double between 1 and 100
            Console.WriteLine("Random double : " + rn2);


            //Finding hypotenuse C = Math.Sqrt(a * a + b * b);
            /*
            Console.WriteLine("enter the length: ");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("enter the height: ");
            int height = Convert.ToInt32(Console.ReadLine());
            double C = Math.Sqrt(a * a + b * b);
            Console.WriteLine("The hypotenious of a triangle is : " + C );
            */

            // String methods
            string str = "   Abhijith   ";
            str = str.ToUpper(); // converts the string to uppercase
            str = str.ToLower(); // converts the string to lowercase
            str = str.Trim(); // removes leading and trailing whitespace
            //str = str.Contains("abh") ? "Contains Abh" : "Does not contain Abh"; // checks if the string contains a substring
            //str = str.Replace("abhijith", "John"); // replaces a substring with another substring
            str = str.Substring(0, 5); // gets a substring from the string (from index 0 to index 5)
            str = str.Insert(0, "Hello "); // inserts a substring at the beginning of the string
            Console.WriteLine(str.Length);
            Console.WriteLine(str);



            Console.ReadKey(); // or Console.ReadLine();
            

        }
    }
}