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
















            Console.ReadKey(); // or Console.ReadLine();


}
}
}