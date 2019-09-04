using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guess_the_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            int secretNumber, guess, guessNo = 0;
            bool playAgain = true;

            // The code provided will print ‘Hello World’ to the console.
            // Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.
            Console.WriteLine("Guess the Number");
            Console.WriteLine("By: Kieron Mead");
            Console.WriteLine("");

            do
            {
                Console.WriteLine("Guess the number generated between 0 and 9!");
                secretNumber = rand.Next(1, 10);
                do
                {
                    guess = Convert.ToInt16(Console.ReadLine());
                    guessNo++;

                    if (guess < secretNumber)
                        Console.WriteLine("Too Low");
                    else if (guess > secretNumber)
                        Console.WriteLine("Too High");
                }
                while (guess != secretNumber);

                Console.WriteLine("\nCorrect!  Guesses:" + guessNo);

            }
            

           
            //Console.WriteLine("The secret number is" + secretNumber);

            //Console.ReadKey();

            // Go to http://aka.ms/dotnet-get-started-console to continue learning how to build a console app! 
        }
    }
}
