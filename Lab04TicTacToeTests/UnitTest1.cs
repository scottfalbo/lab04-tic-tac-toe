using System;
using Xunit;
using Lab04_TicTacToe;
using Lab04_TicTacToe.Classes;

namespace Lab04TicTacToeTests
{
    public class UnitTest1
    {
        /// <summary>
        /// test for a winner given a board
        /// </summary>
        [Fact]
        public void Given_A_Board_Test_For_Winner()
        {
            Board testBoard = new Board();
            //Game testGame = new Game();
            Board.GameBoard[0, 0] = "X";
            Board.GameBoard[1, 1] = "X";
            Board.GameBoard[2, 2] = "X";

            bool isWinner = Game.CheckForWinner(testBoard);
            Assert.True(isWinner);
        }


        [Fact]
        public void Switch_Between_Players()
        {
            Player playerOne = Program.CreatePlayer(1);
            Player playerTwo = Program.CreatePlayer(2);

            Game testGame = new Game(playerOne, playerTwo);
            testGame.SwitchPlayer();

            testGame.PlayerOne.IsTurn = true;

            Assert.True(testGame.PlayerTwo.IsTurn);
        }
    }
}
