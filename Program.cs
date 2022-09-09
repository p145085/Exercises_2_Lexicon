using Microsoft.VisualBasic;
using System;

namespace Exercises_2_Lexicon
{
    internal class Program
    {
        private static void RunExerciseOne()
        {
            string firstName = "John";
            string lastName = "Doe";
            Console.WriteLine("Hello " + firstName + " " + lastName);
        }
        private static void RunExerciseTwo()
        {
            DateOnly today = DateOnly.FromDateTime(DateTime.Now);
            DateOnly tomorrow = today.AddDays(1);
            DateOnly yesterday = today.AddDays(-1);

            Console.WriteLine("Today's date is: " + today);
            Console.WriteLine("Tomorrow is: " + tomorrow);
            Console.WriteLine("Yesterday was: " + yesterday);

        }
        private static void RunExerciseThree()
        {
            Console.Write("Enter your first name: ");
            string? firstName = Console.ReadLine();
            Console.Write("Enter your last name: ");
            string? lastName = Console.ReadLine();
            Console.WriteLine(firstName + " " + lastName);
        }
        private static void RunExerciseFour()
        {
            string str = "The quick fox Jumped Over the DOG";
            str.Replace("quick", "brown");
            int the2 = str.IndexOf("the");
            str.Insert(the2, "lazy");
            Console.WriteLine(str);
            // boring, skip.
        }

        private static void RunExerciseFive()
        {
            string str = "Arrays are very common in programming, they look something like: [1,2,3,4,5]";
            var start = str.IndexOf("["); // Note to self, play around what happens with multiple "[" in the string.
            var end = str.IndexOf("]"); // - .. -

            var foo = str.Substring(start, (end - start + 1)); // Save everything between 'start' and 'end'.

            Console.WriteLine(foo); // Print the found array contents.

            var two = foo.IndexOf("2"); // Find "2".
            var three = foo.IndexOf("3"); // Find "3".

            foo.Remove(two); // Remove "2".
            foo.Remove(three); // Remove "3".

            string result = str.Insert(end, ",6,7,8,9,10");
            Console.WriteLine(result);
        }

        private static void RunExerciseSix()
        {
            Console.WriteLine("Input your first integer: ");
            string? numA = Console.ReadLine();
            int numA1 = Convert.ToInt32(numA);
            Console.WriteLine("Input your second integer: ");
            string? numB = Console.ReadLine();
            int numB1 = Convert.ToInt32(numB);


            var numArray = new int[] { numA1, numB1 };
            var largest = numArray.Max();
            Console.WriteLine("Your largest number is: " + largest);
            var smallest = numArray.Min();
            Console.WriteLine("Your smallest number is: " + smallest);
            var difference = numA1 - numB1;
            Console.WriteLine("The difference is : " + difference);
            var sum = numA1 + numB1;
            Console.WriteLine("The sum is: " + sum);
            var product = numA1 * numB1;
            Console.WriteLine("The product is: " + product);
            var ratio = numA1 / numB1;
            Console.WriteLine("The ratio is: " + ratio);
        }

        private static void RunExerciseSeven(double radius)
        {
            double area = (2 * Math.PI) * (Math.Pow(radius, 2));
            double volume = (4 * Math.PI) * (Math.Pow(radius, 3));

            Console.WriteLine("Area: " + area);
            Console.WriteLine("Volume: " + volume);
        }

        private static void RunExerciseEight(double input)
        {
            var sqr = Math.Pow(input, 2);
            var b10 = Math.Pow(input, 10);

            Console.WriteLine("The square root of your input is: " + sqr);
            Console.WriteLine("Your input to the power of 10 is: " + b10);

        }

        private static void RunExerciseNine()
        {
            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine("Hello " + name);
            Console.WriteLine("What is your birth year?");
            string year = Console.ReadLine();
            int yearInt = Convert.ToInt32(year);
            int age = DateTime.Now.Year - yearInt;
            Console.WriteLine("Your age is: " + age);

            if (age >= 18)
            {
                Console.WriteLine("Would you like a beer?");
                string input = Console.ReadLine();
                if (input.Contains("y"))
                {
                    Console.WriteLine("Coming right up.");
                } else if (input.Contains("n"))
                {
                    Console.WriteLine("Would you like to order a coca cola?");
                    input = Console.ReadLine();
                    if (input.Contains("y"))
                    {
                        Console.WriteLine("Here's your cola.");
                    } else if (input.Contains("n"))
                    {
                        Console.WriteLine("Alright then, stop wasting my time.");
                    }
                } else
                {
                    Console.WriteLine("I didn't understand you.");
                }
            } else if (age < 18)
            {
                Console.WriteLine("Would you like to order a coca cola?");
                string input = Console.ReadLine();
                if (input.Contains("y"))
                {
                    Console.WriteLine("Here's your cola.");
                }
                else if (input.Contains("n"))
                {
                    Console.WriteLine("Alright then, stop wasting my time.");
                }
            }
        }

        private static void RunExerciseTen()
        {
            Console.WriteLine("Choose 1, 2 or 3.");
            string read = Console.ReadLine();
            int input = Convert.ToInt32(read);

            switch (input)
            {
                case 1:
                    Console.WriteLine("Input your first number.");
                    string first = Console.ReadLine();
                    int firstVal = Convert.ToInt32(first);
                    Console.WriteLine("Input your second number.");
                    string second = Console.ReadLine();
                    int secondVal = Convert.ToInt32(second);

                    if (secondVal == 0)
                    {
                        Console.WriteLine("NOOOOOOOO");
                    } else if (secondVal != 0)
                    {
                        Console.WriteLine(firstVal / secondVal);
                    }
                    break;
                case 2:
                    RunExerciseFour();
                    break;
                case 3:
                    if (Console.ForegroundColor == ConsoleColor.White)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    } else if (Console.ForegroundColor == ConsoleColor.Green)
                    {
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    break;
            }
        }

        private static void RunExerciseEleven()
        {
            Console.WriteLine("Input an integer: ");
            int input = Convert.ToInt32(Console.ReadLine());
            if (input > 0)
            {
                for (int i = 0; i < input; i++)
                {
                    if (i % 2 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    Console.WriteLine(i.ToString());
                }
                for (int i = input; i > 0; i--)
                {
                    if (i % 2 == 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                    }
                    Console.WriteLine(i.ToString());
                }

            } else
            {
                Console.WriteLine("Must be greater than 0.");
            }
        }

        private static void RunExerciseTwelve()
        {
            for (int i = 0; i <= 10; i++)
            {
                Console.Write(i + " ");
                for (int j = 0; j <= 10; j++)
                {
                    Console.Write(j * i + " ");
                }
                Console.Write("\n");
            }
        }

        private static void RunExerciseThirteen()
        {
            Random rnd = new Random();
            int rand = rnd.Next(1, 500);
            bool keepLoop = true;
            int guess;
            int count = 0;

            while (keepLoop)
            {
                guess = Convert.ToInt32(Console.ReadLine());
                if (guess < rand)
                {
                    Console.WriteLine("Your guess was lower.");
                } else if (guess > rand)
                {
                    Console.WriteLine("Your guess was higher.");
                } else if (guess == rand)
                {
                    Console.WriteLine("Correct!");
                    Console.WriteLine("It took you " + count + " guesses.");
                    keepLoop = false;
                }
                count++;
            }
        }

        private static void RunExerciseFourteen()
        {
            List<int> lista = new List<int>();
            bool keepLoop = true;
            int result = 0;

            Console.WriteLine("Enter number (stop adding numbers with \"q\".): ");

            while (keepLoop)
            {
                string input = Console.ReadLine();
                if (input.Contains("q"))
                {
                    keepLoop = false;
                    foreach (int i in lista)
                    {
                        result += i;
                    }
                    Console.WriteLine("The sum of your numbers is: " + result);
                    double avg = result / lista.Count;
                    Console.WriteLine("The average value of your numbers is: " + avg);
                }
                lista.Add(Convert.ToInt32(input));
            }

        }

        static void RunExerciseFifteen()
        {
            Console.WriteLine("Enter a number: ");
            string? input = Console.ReadLine();
            int intinput = Convert.ToInt32(input);
            List<int> results = new List<int>();

            try
            {
                for (int i = 0; i < intinput; i++)
                {
                    if ((intinput % i) == 0)
                    {
                        results.Add(i);
                    }
                }

                Console.WriteLine("Your number was divisible by the following numbers: ");
                foreach (int i in results)
                {
                    Console.Write(i + "\t");
                }
            } catch (Exception)
            {
                Console.WriteLine("Error happened.");
            }
        }

        static void Main(string[] args)
        {
            var keepAlive = true;
            while (keepAlive)
            {
                try
                {
                    Console.Write("Enter assignment number (or -1 to exit): ");
                    var assignmentChoice = int.Parse(Console.ReadLine() ?? "");
                    Console.ForegroundColor = ConsoleColor.Green;
                    switch (assignmentChoice)
                    {
                        case 1:
                            RunExerciseOne();
                            break;
                        case 2:
                            RunExerciseTwo();
                            break;
                        case 3:
                            RunExerciseThree();
                            break;
                        case 4:
                            RunExerciseFour();
                            break;
                        case 5:
                            RunExerciseFive();
                            break;
                        case 6:
                            RunExerciseSix();
                            break;
                        case 7:
                            Console.WriteLine("Enter a radius: ");
                            string? input = Console.ReadLine();
                            double value = Convert.ToDouble(input);
                            RunExerciseSeven(value);
                            break;
                        case 8:
                            Console.WriteLine("Enter a number: ");
                            string? input2 = Console.ReadLine();
                            double value2 = Convert.ToDouble(input2);
                            RunExerciseEight(value2);
                            break;
                        case 9:
                            RunExerciseNine();
                            break;
                        case 10:
                            RunExerciseTen();
                            break;
                        case 11:
                            RunExerciseEleven();
                            break;
                        case 12:
                            RunExerciseTwelve();
                            break;
                        case 13:
                            RunExerciseThirteen();
                            break;
                        case 14:
                            RunExerciseFourteen();
                            break;
                        case 15:
                            RunExerciseFifteen();
                            break;
                        case -1:
                            keepAlive = false;
                            break;
                        default:
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("That is not a valid assignment number!");
                            break;
                    }
                    Console.ResetColor();
                    Console.WriteLine("Hit any key to continue!");
                    Console.ReadKey();
                    Console.Clear();
                }
                catch
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("That is not a valid assignment number!");
                    Console.ResetColor();
                }
            }
        }
    }
}