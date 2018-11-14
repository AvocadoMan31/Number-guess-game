using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            GetAppInfo(); // Run GetAppInfo function 

            GreetUser(); // Ask for users name and greet user

            while (true)
            {

                // Init correct number
                // int correctNumber = 7;

                // Create a new random object
                Random random = new Random();

                // Init correct number

                int correctNumber = random.Next(1, 10);

                // Int guess var
                int guess = 0;

                // Ask user for number
                Console.WriteLine("Guess a number between 1 and 10");

                // while guess is not correct
                while (guess != correctNumber)
                {
                    // Get users input
                    string input = Console.ReadLine();

                    // Make user it is a number being input
                    if (!int.TryParse(input, out guess))
                    {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Please pick a number specified in the given range, thank you!");

                        // Keep going
                        continue;
                    }

                    // Cast to int and put in guess
                    guess = Int32.Parse(input);

                    // Match guess to correct number
                    if (guess != correctNumber)
                    {
                        // Print error message
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again");

                    }
                }

                // Output success message
                PrintColorMessage(ConsoleColor.Yellow, "YOU ARE CORRECT! How did you know?");


                // Ask to play again
                Console.WriteLine("Play again? [Y] or [N]");

                // Get answer
                string answer = Console.ReadLine().ToUpper();

                if (answer == "Y")
                {
                    continue;
                }
                else if (answer == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
            }
        }

        // Get and display app info
        static void GetAppInfo()
        {
            // Set  app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Kris Kociski";

            // Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            // Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            // Reset text color
            Console.ResetColor();
        }

        // User input and display user name input
        static void GreetUser()
        {
            // Ask users name
            Console.WriteLine("What is your name?");

            // Get user input
            string inputName = Console.ReadLine();

            Console.WriteLine("Hello {0}, let's play a game...", inputName);

        }

        //Print color message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            // Change text color
            Console.ForegroundColor = color;

            // Tell user it is not a number
            Console.WriteLine(message);

            // Reset text color
            Console.ResetColor();
        }
    }
}
