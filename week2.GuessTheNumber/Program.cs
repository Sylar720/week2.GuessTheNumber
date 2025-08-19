﻿using System;
using System.Runtime.InteropServices;

namespace week2.GuessTheNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                  Random random = new Random();
                int numberToGuess = random.Next(1, 101); // Random number between 1 and 100
                int userGuess = 0;
                int attempts = 0;
                Console.WriteLine("Welcome to 'Guess the Number'!");
                Console.WriteLine("I have selected a number between 1 and 100. Try to guess it!");
                while (userGuess != numberToGuess)
                {
                    Console.Write("Enter your guess: ");
                    string input = Console.ReadLine();
                    if (int.TryParse(input, out userGuess))
                    {
                        attempts++;
                        if (userGuess < numberToGuess)
                        {
                            Console.WriteLine("Too low! Try again.");
                        }
                        else if (userGuess > numberToGuess)
                        {
                            Console.WriteLine("Too high! Try again.");
                        }
                        else
                        {
                            Console.WriteLine($"Congratulations! You've guessed the number {numberToGuess} in {attempts} attempts.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Please enter a valid number.");
                    }
                }
              Console.WriteLine ("Do you want to play again? (yes/no)");
                string playAgain = Console.ReadLine()?.ToLower();
                if (playAgain != "yes")
                {
                    break;
                }

            }
           Console.WriteLine("Thank you for playing!");
        }
    }
}
