using System;

namespace NumberGuesser
{
    //Main Class
    class Program
    {
        //Entry Point Method
        static void Main(string[] args)
        {
            //showing strings and int with Console.WriteLine
            //string name = "Amy Jones";
            //int age = 44;
            //Console.WriteLine("Hello "+name);
            //Console.WriteLine("{0} is {1}", name, age);

            //Set app vars
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Amy Jones";

            //Change text color
            Console.ForegroundColor = ConsoleColor.Green;

            //Write out app info
            Console.WriteLine("{0}: Version {1} by {2}", appName, appVersion, appAuthor);

            //Reset text color
            Console.ResetColor();

            //Ask user name
            Console.WriteLine("What is your name?");

            //Get user input
            string inputName = Console.ReadLine();

            //Write out name from user input
            Console.WriteLine("Hello {0}, let's play a game...", inputName);

            while (true)
            {

                //Set correct number
                //int correctNumber = 7;

                //Create a new Random object
                Random random = new Random();

                int correctNumber = random.Next(1, 10);

                //Guess var
                int guess = 0;

                //Ask user for number
                Console.WriteLine("Guess a number between 1 and 10");

                //While guess is not correct
                while (guess != correctNumber)
                {
                    //Get Users Input
                    string input = Console.ReadLine();

                    // Make sure input is a number
                    if (!int.TryParse(input, out guess))
                    {
                        //Change text color
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;

                        //Not a number text
                        Console.WriteLine("Please enter a number.");

                        //Reset text color
                        Console.ResetColor();

                        //Keep going
                        continue;
                    }

                    //Cast to int and put in guess
                    guess = Int32.Parse(input);

                    //Match guess to correct number
                    if (guess != correctNumber)
                    {
                        //Change text color
                        Console.ForegroundColor = ConsoleColor.Red;

                        //Text for wrong answer
                        Console.WriteLine("Wrong number, please try again.");

                        //Reset text color
                        Console.ResetColor();
                    }

                }

                //Output success message
                //Change text color
                Console.ForegroundColor = ConsoleColor.Blue;

                //text for right answer
                Console.WriteLine("You guessed the right number.");

                //Reset text color
                Console.ResetColor();

                //Ask to play again
                Console.WriteLine("Play again? [Y or N]");

                // Get answer to play again
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
    }
}
