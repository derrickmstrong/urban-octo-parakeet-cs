using System;

namespace Refresher
{
    class Program
    {
        static void Main(string[] args)
        {
            /* https://www.youtube.com/watch?v=GhQdlIFylQ8 */

            // Variables
            string firstName = "Derrick";
            char lastInitial = 'S';
            int age = 41;
            bool response = true;
            double gpa = 3.9;

            Console.WriteLine($"Hello, {firstName.ToUpper()} {lastInitial}. \nAre you {age}? {response} \nGPA: {gpa}");

            //// String Methods
            //Console.WriteLine(firstName.Length);
            //Console.WriteLine(firstName.ToUpper());
            //Console.WriteLine(firstName.Contains("rick"));
            //Console.WriteLine(firstName[0]);
            //Console.WriteLine(firstName.IndexOf("rick"));
            //Console.WriteLine(firstName.Substring(3));
            //Console.WriteLine(firstName.Substring(3, 3));

            //// Numbers
            //Console.WriteLine(-15.789 + 6.435);
            //Console.WriteLine(Math.Sqrt(49));
            //Console.WriteLine(Math.Max(49,32));
            //int num = Convert.ToInt32("45");
            //Console.WriteLine(num + 4);

            //// Simple Application
            //Console.Write("Enter your name: ");
            //string name = Console.ReadLine();
            //Console.WriteLine($"Hello {name}!");

            //// Simple Calculator Application
            //Console.Write("Enter a number: ");
            //double num1 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Enter another number: ");
            //double num2 = Convert.ToDouble(Console.ReadLine());
            //Console.WriteLine($"Add: {num1 + num2}");
            //Console.WriteLine($"Subtract: {num1 - num2}");
            //Console.WriteLine($"Multiply: {num1 * num2}");
            //Console.WriteLine($"Divide: {num1 / num2}");
            //Console.WriteLine($"Remainder: {num1 % num2}");

            ////Simple Mad Libs
            //string color, pluralNoun, celebrity;

            //Console.Write("Enter a color: ");
            //color = Console.ReadLine();

            //Console.Write("Enter a plural noun: ");
            //pluralNoun = Console.ReadLine();

            //Console.Write("Enter a celebrity: ");
            //celebrity = Console.ReadLine();

            //Console.WriteLine($"\nRoses are {color}.\n{pluralNoun} are blue.\nI LOVE {celebrity} and you too!\n");

            ////Arrays
            //int[] luckyNumbers = { 7, 11, 23, 34, 45, 79 };
            //luckyNumbers[3] = 8; // Update element 4's value

            //Console.WriteLine(luckyNumbers[3]);

            //string[] friends = new string[5];
            //friends[0] = "Fee";
            //friends[1] = "Sam";

            //Console.WriteLine($"My friends are {friends[0]} and {friends[1]}.");

            ////Call SayHi method
            //SayHi("Derrick", 41);

            ////Print + Call Cube method
            //Console.WriteLine(Cube(2));

            // Conditionals
            //bool isMale = false;

            //if (isMale)
            //{
            //    Console.WriteLine("You are a male.");
            //}
            //else
            //{
            //    Console.WriteLine("You are not male.");
            //}

            //// Print + Call GetMax method 
            //Console.WriteLine($"{GetMax(2, 7, 7)}  is the greater number.");

            //// Better Calculator app
            //Console.Write("Enter a number: ");
            //double num1 = Convert.ToDouble(Console.ReadLine());
            //Console.Write("Enter an operator (+, -, *, /, %): ");
            //char op = Convert.ToChar(Console.ReadLine());
            //Console.Write("Enter a number: ");
            //double num2 = Convert.ToDouble(Console.ReadLine());

            //if (op == '+')
            //{
            //    Console.WriteLine(num1 + num2);
            //}
            //else if (op == '-')
            //{
            //    Console.WriteLine(num1 - num2);
            //}
            //else if (op == '*')
            //{
            //    Console.WriteLine(num1 * num2);
            //}
            //else if (op == '/')
            //{
            //    Console.WriteLine(num1 / num2);
            //}
            //else if (op == '%')
            //{
            //    Console.WriteLine(num1 % num2);
            //}
            //else
            //{
            //    Console.WriteLine("Invalid operator. Please try again!");
            //}

            //// Call GetDay Method
            //Console.WriteLine($"Today is {GetDay()}.");

            //// Create a While loop
            //int index = 1;
            //while (index <= 5)
            //{
            //    Console.WriteLine(index);
            //    index++;
            //}

            //// Do While loop
            //int index = 7;
            //do
            //{
            //    Console.WriteLine(index);
            //    index--;
            //} while (index <= 5);

            //// Guessing Game with While loop
            //string secretWord = "Money";
            //string guess = "";

            //while(guess != secretWord)
            //{
            //    Console.Write("Guess a word that sounds like funny but can buy you honey: ");
            //    guess = Console.ReadLine();
            //}
            //Console.Write("That's Correct");

            //// Guessing Game with Do While loop with Guess Limit and Conditional Messaging
            //string secretWord = "Malone";
            //string guess = "";
            //int guessCount = 0;
            //int guessLimit = 3;

            //do
            //{
            //    Console.Write("Guess my middle name: ");
            //    guess = Console.ReadLine();

            //    guessCount++; // Increase guessCount

            //    if (guess.ToLower() != secretWord.ToLower() && guessCount >= guessLimit)
            //    {
            //        Console.WriteLine("Sorry, you are all out of guesses.");
            //        break;
            //    }
            //    else if (guess.ToLower() != secretWord.ToLower())
            //    {
            //        Console.WriteLine($"Nah, try again!\nYou have {3 - guessCount} {Guesses(guessCount)} left.\n"); // See Guesses Method below
            //    }
            //    else if (guess.ToLower() == secretWord.ToLower() && guessCount == guessLimit)
            //    {
            //        Console.WriteLine("Yep and you guessed it on your last try!");
            //        break;
            //    }
            //    else if (guess.ToLower() == secretWord.ToLower())
            //    {
            //        Console.WriteLine("Yep, you guessed it!");
            //        break;
            //    }

            //} while (guess.ToLower() != secretWord.ToLower());

            //// For loop
            //for (int i = 1; i <= 5; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //// Loop through lucky numbers array
            //int[] luckyNumbers = { 7, 11, 23, 34, 45, 79 };
            //for (int i = 0; i < luckyNumbers.Length; i++)
            //{
            //    Console.WriteLine(luckyNumbers[i]);
            //}

            //// Call GetPow Method
            //Console.WriteLine(GetPow(2, -3));
            //Console.WriteLine(GetPow(10, 3));
            //Console.WriteLine($"{GetPow(7, 5)}\n\n");

            //// Call GetPowWithLoop Method - All negative pows will be turned positive via Math.Abs()
            //Console.WriteLine(GetPowWithLoop(2, -3));
            //Console.WriteLine(GetPowWithLoop(10, 3));
            //Console.WriteLine(GetPowWithLoop(7, 5));

            //// 2D array
            //int[,] numGrid =
            //{
            //    {1, 2, 3 },
            //    {4, 5, 6 },
            //    {7, 8, 9 },
            //};
            //Console.WriteLine(numGrid[2, 0]); // First argument is subarray, Second argument is the value in that array

            //// Exception Handling with try/catch for all errors
            //try
            //{
            //    Console.Write("Enter a number: ");
            //    int num1 = Convert.ToInt32(Console.ReadLine());

            //    Console.Write("Enter a number: ");
            //    int num2 = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine(num1 / num2);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //// Exception Handling with try/catch for multiple specific errors/exceptions (DivideByZeroException, FormatException)
            //try
            //{
            //    Console.Write("Enter a number: ");
            //    int num1 = Convert.ToInt32(Console.ReadLine());

            //    Console.Write("Enter a number: ");
            //    int num2 = Convert.ToInt32(Console.ReadLine());

            //    Console.WriteLine(num1 / num2);
            //}
            //catch (DivideByZeroException ex)
            //{
            //    Console.WriteLine("No no no... " + ex.Message);
            //}
            //catch (FormatException ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //// Classes and Objects - see Book
            //Book book1 = new Book("Harry Potter", "JK Rowling", 400); // Instance of a Book / Book object
            //Book book2 = new Book("Lord of the Rings", "Tolkein", 700); // Instance of a Book / Book object

            //book2.title = "The Hobbit";

            //Console.WriteLine($"{book1.title} by {book1.author}");
            //Console.WriteLine($"{book2.title} by {book2.author}");

            //// Classes, Objects, and Methods - see Student
            //Student student1 = new Student("Derrick", "Marketing", 3.8);
            //Student student2 = new Student("Seven", "Marketing", 3.0);

            //Console.WriteLine($"{student1.name} is a {student1.major} major.");
            //Console.WriteLine($"{student2.name} is a {student2.major} major.");

            //Console.WriteLine(student1.HasHonors());
            //Console.WriteLine(student2.HasHonors());

            //// Getters and Setters - see Movie
            //Movie movie1 = new Movie("Training Day", "Denzel Washington", "R");

            //movie1.Introduction();

            //// Static attributes modifier - see Song
            //Song song1 = new Song("Hey Ya", "Andre3000", 700);
            //Song song2 = new Song("Ms. Jackson", "Outkast", 570);

            //Console.WriteLine(song1.title); // Hey Ya
            //Console.WriteLine(Song.songCount); // Initially its 0 but after adding 2 songs its 2

            //Console.WriteLine(song1.getSongCount()); // Using a method to get songCount off a particular instance

            //// Static methods and Static classes - see UsefulTools
            //Console.WriteLine(Math.Sqrt(64)); // Sqrt() is an example of a Static Method because it belongs to the class and not an instance of the class
            //UsefulTools.SayHi("Derrick"); // Because SayHi is a static method it can be called on the UsefulTools class. Note UsefulTolls class is a static class so it can not have instances made from it

            // Inheritance - see Chef and ItalianChef
            Chef uncleBen = new Chef();
            uncleBen.MakeChicken();
            uncleBen.MakeSpeciality();

            ItalianChef mario = new ItalianChef();
            mario.MakeSalad();
            mario.MakeSpeciality();
            mario.MakePasta();

        }


        //// Methods - Outside of Main method
        //static void SayHi(string name, int age)
        //{
        //    Console.WriteLine($"Hello {name}! You are {age}.");
        //}

        //// Return statement inside Method
        //static double Cube(double num)
        //{
        //    double result = Math.Pow(num, 3);
        //    return result;
        //}

        //// GetMax method
        //static int GetMax(int num1, int num2, int num3)
        //{
        //    int result;

        //    if (num1 > num2 && num1 > num3)
        //    {
        //        result = num1;
        //    } else if (num2 > num1 && num2 > num3)
        //    {
        //        result = num2;
        //    }
        //    else
        //    {
        //        result = num3;
        //    }

        //    return result;
        //}

        //// Get the Name of Day of the Week using a Switch statment/expression
        //static string GetDay()
        //{
        //    // Assign dayOfWeek via DateTime method
        //    int dayOfWeek = (int)DateTime.Today.DayOfWeek;
        //    // Switch statement converted into an expression
        //    string dayName = dayOfWeek switch
        //    {
        //        0 => "Sunday",
        //        1 => "Monday",
        //        2 => "Tuesday",
        //        3 => "Wednesday",
        //        4 => "Thursday",
        //        5 => "Friday",
        //        6 => "Saturday",
        //        _ => "Unknown Error",
        //    };
        //    return dayName;
        //}

        //// Guess vs Guesses Method
        //static string Guesses(int guessCount)
        //{
        //    if (guessCount == 2)
        //    {
        //        return "guess";
        //    } else
        //    {
        //        return "guesses";
        //    }
        //}

        //// Exponent Method with Math.Pow method
        //static double GetPow(double num, double pow)
        //{
        //    return Math.Pow(num, pow);
        //}

        //// Exponent Method with for loop  - All negative pows will be turned positive via Math.Abs()
        //static int GetPowWithLoop(int num, int pow)
        //{
        //    int result = 1;

        //    for(int i = 0; i < Math.Abs(pow); i++)
        //    {
        //        result *= num; // Multiply the (num) by itself (pow) number of times (due to the loop repeating pow number of times)
        //    }

        //    return result;
        //}
    }
    
}
