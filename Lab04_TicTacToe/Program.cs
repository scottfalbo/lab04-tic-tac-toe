using System;
using Lab04_TicTacToe.Classes;

namespace Lab04_TicTacToe
{
    public class Program
    {
        static void Main(string[] args)
        {
            StartGame();
        }

        static void StartGame()
        {

            Player playerOne = CreatePlayer(1);
            Player playerTwo = CreatePlayer(2);
            playerOne.IsTurn = true;
            Game newGame = MakeGame(playerOne, playerTwo);

            Player winner = newGame.Play(playerOne, playerTwo);

            if (winner.Name == "draw")
                Console.WriteLine("It's a draw");
            else
                Console.WriteLine($"{winner.Marker} wins the game!, Congrats {winner.Name}");

        }
        static public Player CreatePlayer(int playerNumber)
        {
            Console.WriteLine($"Player {playerNumber} please enter your name:");
            string userInput = Console.ReadLine();
            Player newPlayer = new Player()
            {
                Name = userInput,
                Marker = playerNumber == 1 ? "X" : "O"
            };
            return newPlayer;
        }
        static Game MakeGame(Player playerOne, Player playerTwo)
        {
            return new Game(playerOne, playerTwo);
        }

    }
}

