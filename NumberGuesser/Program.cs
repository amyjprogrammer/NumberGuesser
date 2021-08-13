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

            //run GetAppInfo function
            GetAppInfo();

            //run GreetUser function found below
            GreetUser();

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
                        //use Color function
                        PrintColorMessage(ConsoleColor.DarkMagenta,"Please enter a number." );
                      
                        //Keep going
                        continue;
                    }

                    //Cast to int and put in guess
                    guess = Int32.Parse(input);

                    //Match guess to correct number
                    if (guess != correctNumber)
                    {
                        //user Color function
                        PrintColorMessage(ConsoleColor.Red, "Wrong number, please try again.");
                    
                    }

                }

                //Output success message
                //Use Color function
                PrintColorMessage(ConsoleColor.Blue, "You guessed the right number!");
                

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

        //separate function to display app info
        static void GetAppInfo()
        {
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
        }

        //separate function to get user Name and greet
        static void GreetUser()
        {
            //Ask user name
            Console.WriteLine("What is your name?");

            //Get user input
            string inputName = Console.ReadLine();

            //Write out name from user input
            Console.WriteLine("Hello {0}, let's play a game...", inputName);

        }

        //Print color message
        static void PrintColorMessage(ConsoleColor color, string message)
        {
            //Change text color
            Console.ForegroundColor = color;

            //text 
            Console.WriteLine(message);

            //Reset text color
            Console.ResetColor();

        }
    }
}
