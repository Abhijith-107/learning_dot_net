using System;
using System.ComponentModel.Design;
using System.Linq;
using System.Numerics;


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
            /*
            Console.WriteLine("whats your name ?");
            String name = Console.ReadLine(); // to get input from user 
            Console.WriteLine("hello"+name+"have a great day!");
            */
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
/*
            Random random = new Random(); // creates a new instance of the Random class
            int rn = random.Next(1, 100); // generates a random number between 1 and 100
            double rn2 = random.NextDouble();// generates a random double between 1 and 100
            Console.WriteLine("Random double : " + rn2);
*/

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

            /*
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

            string name = "Abhi";
            object clone = name.Clone();
            Console.WriteLine(clone);  // Output: Abhi

            int result = string.Compare("apple", "banana");
            Console.WriteLine(result); // Output: < 0 because "apple" comes before "banana"

            int result = string.CompareOrdinal("a", "A");
            Console.WriteLine(result); // Output: > 0 because 'a' > 'A' in Unicode

            string name = "apple";
            int result = name.CompareTo("banana");
            Console.WriteLine(result); // Output: < 0

            string full = string.Concat("Hello", " World");
            Console.WriteLine(full); // Output: Hello World

            string sentence = "Welcome to .NET";
            Console.WriteLine(sentence.Contains(".NET")); // Output: True

            string full = string.Concat("Hello", " World");
            Console.WriteLine(full); // Output: Hello World

            string sentence = "Welcome to .NET";
            Console.WriteLine(sentence.Contains(".NET")); // Output: True

            bool isEqual = string.Equals("hello", "hello");
            Console.WriteLine(isEqual); // Output: True

            string name = "Abhi";
            string message = string.Format("Hello, {0}!", name);
            Console.WriteLine(message); // Output: Hello, Abhi!'

            string word = "Hi";
            foreach (char c in word)
            {
                Console.WriteLine(c); // Output: H \n i
            }

            string s = "abc";
            Console.WriteLine(s.GetHashCode()); // Output: (varies)

            string text = "hello";
            Console.WriteLine(text.GetType()); // Output: System.String

            string s = "hi";
            Console.WriteLine(s.GetTypeCode()); // Output: String

            string s = "hello world";
            Console.WriteLine(s.IndexOf("world")); // Output: 6

            string[] words = { "C#", "Java", "Python" };
            string result = string.Join(", ", words);
            Console.WriteLine(result); // Output: C#, Java, Python

            string s = "Hello World";
            string updated = s.Insert(6, "Beautiful ");
            Console.WriteLine(updated); // Output: Hello Beautiful World

            string a = string.Intern("hello"); //

            string s = "hi";
            Console.WriteLine(string.IsInterned(s)); // Output: hi

            string s = "café";
            Console.WriteLine(s.IsNormalized()); // Output: True (most of the time)

            string input = "";
            Console.WriteLine(string.IsNullOrEmpty(input)); // Output: True

            string input = "   ";
            Console.WriteLine(string.IsNullOrWhiteSpace(input)); // Output: True



            Console.WriteLine(sentence.Contains(".NET")); // Output: True

            */

// if statement - order of the if else statement matter while using else if 
            /*
            Console.WriteLine("enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            if (age > 18)
            {
                Console.WriteLine("Congo");
            }
            else if(age < 0){
                Console.WriteLine("Invalid ");
            }
            else {
                Console.WriteLine("Next Year Bud!!");
            }
            */


// switch statement

            /*
            Console.WriteLine("Enter the day of the week: ");
            String day = Console.ReadLine().ToLower();

            switch (day)
            {
                case "monday":
                    Console.WriteLine("Today is Monday");
                    break;
                case "tuesday":
                    Console.WriteLine("Today is Tuesday");
                    break;
                case "wednesday":
                    Console.WriteLine("Today is Wednesday");
                    break;
                case "thursday":
                    Console.WriteLine("Today is Thursday");
                    break;
                case "friday":
                    Console.WriteLine("Today is Friday");
                    break;
                case "saturday":
                    Console.WriteLine("Today is Saturday");
                    break;
                case "sunday":  
                    Console.WriteLine("Today is Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid day");
                    break;
            }
            */

// logical operators
            /*
             * && - AND operator
             * || - OR operator
            */


// while loop  //

            // infinite loop 

            /*
             while( 1 == 1 ){
                Console.WriteLine("infinite loop")
            }
             */

            /*
            int i = 20;
            while (i != 0)
            {
                Console.WriteLine(i);
                i--;
            }
            */


// for-loop statement //
            /*
                        for (int i = 0; i < 10; i++)
                        {
                            Console.WriteLine(i);
                        }

                        */

// Nested for loop //
            /*
            Console.Write("how many rows:");
            int rows  = Convert.ToInt32(Console.ReadLine());

            Console.Write("how many columns:");
            int columns = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine(); // move to the next line after each row
            }
            */

            /*
            int rows = 4;
            int cols = 4;

           
             
             ****
             *--*
             *--*
             *--*
             ****
             
            
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    // Print '*' on the border (first and last row, or first and last column)
                    if (i == 0 || i == rows - 1 || j == 0 || j == cols - 1)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write("-");
                    }
                }
                Console.WriteLine(); // Move to the next row
            }

            */

//  RANDOM NUMBER GUESSING GAME //

            /*
            Random rnum = new Random();
            bool game = true;

            int minn = 1;
            int maxx = 100;

            int guess;
            int number;
            int guesses;
            String response;

            while (game) {
                guess = 0;
                guesses = 0;
                response = "";
                number = rnum.Next(minn, maxx+1);

                while (guess != number) { 

                Console.WriteLine("Guess a number between " + minn + " and " + maxx + ": ");
                guess = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("You guessed: " + guess);

                    if (guess < number) { 
                    Console.WriteLine("Too low! Try again.");
                    }
                    else if (guess > number) {
                        Console.WriteLine("Too high! Try again.");
                    }
                    guesses++;
                }
                Console.WriteLine("Number "+ number);
                Console.WriteLine("You win!! ");
                Console.WriteLine("guesses: "+guesses);

                Console.WriteLine("Do you want to play again? (Y/N)");
                response = Console.ReadLine().ToUpper();
                if (response != "Y") {
                    game = false;
                    Console.WriteLine("Thanks for playing!");
                }
            }

            */

//  Rock paper scissors game  //

            /*

               string[] strs = {"rock", "paper", "scissor"};
               int userscore = 0, compscore = 0;
               Random random = new Random();

               Console.WriteLine("rock, paper, scissor!");

               for (int count = 0; count < 3; count++)
               {
                   Console.Write("Enter your choice: ");
                   string user = Console.ReadLine().Trim().ToLower();

                   // Validate input
                   if (!strs.Contains(user))
                   {
                       Console.WriteLine("Invalid input!");
                       count--; // Retry the round
                       continue;
                   }

                   string comp = strs[random.Next(0, 3)];
                   Console.WriteLine($"Computer chose: {comp}");

                   if (user == comp)
                   {
                       Console.WriteLine("It's a tie!");
                   }
                   else if ((user == "rock" && comp == "scissor") ||
                            (user == "paper" && comp == "rock") ||
                            (user == "scissor" && comp == "paper"))
                   {
                       Console.WriteLine("You win!");
                       userscore++;
                   }
                   else
                   {
                       Console.WriteLine("Computer wins!");
                       compscore++;
                   }
               }

               Console.WriteLine($"\nFinal Score - You: {userscore} | Computer: {compscore}");

               */

            String str01 = "abhi";
            String str02 = "buddy";
            //int hash = str11.GetHashCode();
            byte dup = 255; // max value is 0 - 255 for BYTE
            //t demo01 = '8';
            //Console.WriteLine(demo01);
            Console.WriteLine(dup);
            Console.WriteLine($"hey {str01} how you doing {str02}");


            //  TYPE CONVERSION - CONVERT , PARSE , TRYPARSE
            /*
             string input = "123";

                    //Convert
                    int a = Convert.ToInt32(input);
                    Console.WriteLine("Convert: " + a); // Output: 123

                    //Parse
                    int b = int.Parse(input);
                    Console.WriteLine("Parse: " + b);   // Output: 123

                    //TryParse
                    bool isValid = int.TryParse(input, out int c);
                    if (isValid)
                        Console.WriteLine("TryParse: " + c); // Output: 123
                    else
                        Console.WriteLine("Invalid input");
             */

            // ATM assignment 
            /*
                        string[] cardno = { "123456", "321654", "789456", "741258" };
                        string[] pinno = { "123", "456", "789", "987" };

                        Console.WriteLine("Welcome to ABC ATM");
                        Console.Write("Enter your card number: ");
                        string? inputcardno = Console.ReadLine();   // string? allows null input

                        int cardIndex = Array.IndexOf(cardno, inputcardno); // Array.IndexOf(String[] , value)

                        if (cardIndex != -1)  // Card number found
                        {
                            Console.Write("Enter your 3-digit pin: ");
                            string? inputpinno = Console.ReadLine();

                            if (inputpinno == pinno[cardIndex])
                            {
                                Console.WriteLine("Hey, welcome dude!!");
                            }
                            else
                            {
                                Console.WriteLine("Incorrect PIN.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Card number not recognized.");
                        }
            */

            //  Calculator program  //

            /*
            Console.WriteLine("Well well what shall we calculate !!");
            Console.WriteLine("Enter num_1 : ");
            int num11 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the operator (+, -, *, /): ");

            char op = Console.ReadLine()[0]; // Read the first character as the operator

            Console.WriteLine("Enter num_2 : ");
            int num12 = Convert.ToInt32(Console.ReadLine());

            switch (op) { 
                case '+':
                    Console.WriteLine($"\nResult: {num11 + num12}");
                    break;
                case '-':
                    Console.WriteLine($"\nResult: {num11 - num12}");
                    break;
                case '*':
                    Console.WriteLine($"\nResult: {num11 * num12}");
                    break;
                case '/':
                    if (num12 != 0) {
                        Console.WriteLine($"\nResult: {num11 / num12}");
                    } else {
                        Console.WriteLine("\nError: Division by zero is not allowed.");
                    }
                    break;
                default:
                    Console.WriteLine("\nError: Invalid operator. Please use +, -, *, or /.");
                    break;
            }
            */

// Arrays in C# - similar to Java arrays

            String[] cars = { "Volvo", "BMW", "Ford", "Mazda" };

            foreach (String car in cars) {
                Console.WriteLine(car);
            }

            // Print every second car in the array used for skipping elements
            for (int i = 0; i < cars.Length; i+=2) {
                Console.WriteLine(cars[i]);
            }
// Method in C#

            // method performs a specific task and can be reused
            // Methods can have parameters and return values
            // Method declaration: accessModifier returnType methodName(parameters) { method body }

            String name = "Abhijith";

            happyBirthday(name);
            happyBirthday(name);

            static void happyBirthday(String name)
            { 
                Console.WriteLine($"happy bday {name}");
            }

// RETURN keyword in C#
// return keyword is used to return a value from a method
/*
            int a1 = 5;
            int b1 = 10;

            Console.WriteLine(add(a1, b1));

            static int add(int a1 , int b1) {
                int sum1 = a1 + b1;
                return sum1;
            } 
*/

//  METHOD OVERLOADING in C#

            multi(5,10);
            multi(5, 10, 15);

// PARAMS in c# is used to pass a variable number of arguments to a method

            double total = CheckOut(3.99, 10, 2.13, 20, 45);
            Console.WriteLine($"Total: {total}");


//  Exception handling in C#  //

            try
            {
                Console.WriteLine("Enter a number: ");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine($"You entered: {num}");
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Invalid input. Please enter a valid number.");
            }
            catch (OverflowException ex)
            {
                Console.WriteLine("Number is too large or too small.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred: " + ex.Message);
            }
            finally {
                Console.WriteLine("This block always executes, regardless of exceptions.");
            }

// ternary operator in C#

            int x = 10;
            int y = 20;
            int minxy = (x < y) ? x : y; // if x is less than y, min = x, else min = y
            Console.WriteLine($"The minimum value is: {minxy}");






            Console.ReadKey(); // or Console.ReadLine();

        }

// PARAMS in C# allows us to pass a variable number of arguments to a method

        static double CheckOut(params double[] prices) {
            double total = 0;
            foreach (double price in prices) {
                total += price;
            }
            return total;

        }


// Method overloading is a feature that allows us to define multiple methods with the same name but different parameters
// its better to call methods outside the main method
        
        static void multi(double a2, double b2)
        {
            Console.WriteLine($"{a2} X {b2} = {a2 * b2}");
        }
        static void multi(double a2, double b2, double c2)
        {
            Console.WriteLine($"{a2} X {b2} X {c2} = {a2 * b2 * c2}");
        }
    }
}