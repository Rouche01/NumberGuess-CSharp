using System.Linq;
using System;
using System.Collections.Generic;

namespace numberGuessGame
{
    class Program
    {
        static void Main(string[] args)
        {

            string userInputLevel;

            Console.Write("What level do you want to play?(Easy/Medium/Hard): ");
            userInputLevel = Console.ReadLine();

            if(userInputLevel.ToLower() == "easy") {
                // Console.WriteLine("asy");
                int startInt = 1;
                Random random = new Random();
                int ranNum = random.Next(1, 10);
                
                while (startInt <= 6)
                {
                    int userGuess;  
                    Console.Write("Make a guess, between 1 and 10: ");
                    userGuess = int.Parse(Console.ReadLine());
                    if (userGuess == ranNum) {
                        Console.WriteLine("You got it right! You won!");
                    } else {
                        Console.WriteLine("That was wrong!");
                        Console.WriteLine("You have " + (6 - startInt) + " guess left");
                    }
                    startInt = startInt + 1;
                }
                Console.WriteLine("Game Over");
            } else if (userInputLevel.ToLower() == "medium") {
                int startInt = 1;
                Random random = new Random();
                int ranNum = random.Next(1, 20);
                
                while (startInt <= 4)
                {
                    int userGuess;  
                    Console.Write("Make a guess, between 1 and 20: ");
                    userGuess = int.Parse(Console.ReadLine());
                    if (userGuess == ranNum) {
                        Console.WriteLine("You got it right! You won!");
                        break;
                    } else {
                        Console.WriteLine("That was wrong!");
                        Console.WriteLine("You have " + (4 - startInt) + " guess left");
                    }
                    startInt = startInt + 1;
                }
                Console.WriteLine("Game Over");
            } else if (userInputLevel.ToLower() == "hard") {
                int startInt = 1;
                Random random = new Random();
                int ranNum = random.Next(1, 50);
                
                while (startInt <= 3)
                {
                    int userGuess;  
                    Console.Write("Make a guess, between 1 and 50: ");
                    userGuess = int.Parse(Console.ReadLine());
                    if (userGuess == ranNum) {
                        Console.WriteLine("You got it right! You won!");
                    } else {
                        Console.WriteLine("That was wrong!");
                        Console.WriteLine("You have " + (3 - startInt) + " guess left");
                    }
                    startInt = startInt + 1;
                }
                Console.WriteLine("Game Over");
            }
            
            
        }
    }
}
