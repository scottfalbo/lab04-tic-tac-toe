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

        /*
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
        */

        /// <summary>
        /// Given a position test that the method is returning the proper matrix coords
        /// </summary>
        /// <param name="position"></param>
        /// <param name="expectedCoords"></param>
        [Theory]
        [InlineData(1, new int[] { 0, 0 })]
        [InlineData(3, new int[] { 0, 2 })]
        [InlineData(5, new int[] { 1, 1 })]
        [InlineData(7, new int[] { 2, 0 })]
        public void Input_Position_Equals_Correct_Coords(int position, int[] expectedCoords)
        {
            Position result = Player.PositionForNumber(position);
            int[] resultToCoords = new int[] { result.Row, result.Column };
            
            Assert.Equal(expectedCoords, resultToCoords);
        }
    }
}
