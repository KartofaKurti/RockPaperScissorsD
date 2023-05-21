using System;

namespace RockPaperScissorsD
{
    internal class RockPaperScissorsD
    {
        static void Main(string[] args)
        {
            //colors
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.BackgroundColor = ConsoleColor.Black;


            //Constants
            const string rock = "Rock";
            const string paper = "Paper";
            const string scissors = "scissors";


            //Computerr move
            Random  random = new Random();  
            int computerRandomMove = random.Next(1, 4);
            string computerMove = "";


            //Player move
            Console.WriteLine("Choose [r]ock, [p]aper, [s]cissors:");
            Console.ForegroundColor = ConsoleColor.Red;
            string playerMove = Console.ReadLine();


            //Player pick
            if (playerMove == "r" || playerMove == "rock")
            {
                playerMove = rock;
            }
            else if (playerMove == "p" || playerMove == "paper")
            {
                playerMove = paper;
            }
            else if (playerMove == "s" || playerMove == "scissors")
            {
                playerMove = scissors;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Invalid input. Try again...?");
            }


            //Computer pick
            switch (computerRandomMove)
            {
                case 1:
                    computerMove = rock;
                    break;
                case 2:
                    computerMove = paper;
                        break;
                case 3:
                    computerMove = scissors;
                    break;
            }


            //Player wins situatioons
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"The computer chose {computerMove}.");
            if ((playerMove == rock && computerMove == scissors) || 
                (playerMove == paper && computerMove == rock) || 
                (playerMove == scissors && computerMove == paper))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("You win.");
            }
            //Computer win situations
            else if ((playerMove == scissors && computerMove == rock) ||
                (playerMove == rock && computerMove == paper) ||
                (playerMove == paper && computerMove == scissors))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("You lose.");
            }
            //Draw
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("This game is a draw.");
            }
            Console.ResetColor();
            
        }
    }
}
