using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            int ranNum = r.Next(1, 100);

            Console.WriteLine("Welcome to the Number Guessing Game");

            Console.WriteLine("Please guess a number between 0 and 100");

            int guessNum = -1;

            while (true)
            {
                Console.Write("Enter your choice: ");
                string guessStr = Console.ReadLine();
                try
                {
                    guessNum = int.Parse(guessStr);
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid Input. A number needs to be entered");
                    throw;
                }
                
                if (guessNum <= 0 || guessNum > 100)
                {
                    Console.WriteLine("You have entered a number outside the range of 0 to 100. Please enter one within the range");
                } else if (guessNum > ranNum)
                {
                    Console.WriteLine("The Number you have entered is too high. Try lower");
                }
                else if (guessNum < ranNum)
                {
                    Console.WriteLine("The Number you have entered is too low. Try higher");
                }
                else if (guessNum == ranNum)
                {
                    Console.WriteLine("You have guessed the number correctly. You win!");
                    break;
                }

            }
            Console.ReadLine();

        }
    }
}
