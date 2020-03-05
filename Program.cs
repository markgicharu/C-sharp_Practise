using System;

namespace GuesserGame
{
    class Program
    {
        private const int V = 0;

        static void Main(string[] args)
        {
            //guesser game
            //correct number
           // int correctNumber = 9;
            //guess number
            int guess = V;

            //create random

            Random random = new Random();

            int correctNumber = random.Next(1, 10);

            while (true)
            {
                //ask user input
                Console.WriteLine("Guess a number between 1 and 10");

                while (guess != correctNumber)
                {
                    //get user input
                    string input = Console.ReadLine();

                    //make sure user entry is a number
                    if (!int.TryParse(input, out guess))
                    {
                        //change console text color
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        //change console background color
                        Console.BackgroundColor = ConsoleColor.DarkBlue;

                        //prompt wrong answer
                        Console.WriteLine("Please enter an actual number, try again");

                        Console.ResetColor();

                        //keep going
                        continue;
                    }


                    //cast into int
                    guess = Int32.Parse(input);

                    //match guess to correct number
                    if (guess != correctNumber)
                    {
                        //change console text color
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        //change console background color
                        Console.BackgroundColor = ConsoleColor.DarkBlue;

                        //prompt wrong answer
                        Console.WriteLine("Wrong number, try again");

                        //reset color
                        Console.ResetColor();


                    }
                }

                Console.ForegroundColor = ConsoleColor.Green;
                //output success message
                Console.WriteLine("Correct number chosen");
                Console.ResetColor();
                //ask user to replay game
                Console.WriteLine("Play Again? [Y or N]");

                //get answer
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
