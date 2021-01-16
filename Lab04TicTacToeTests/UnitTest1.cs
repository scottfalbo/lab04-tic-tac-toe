using System;
using Xunit;
using Lab04_TicTacToe;
using Lab04_TicTacToe.Classes;

namespace Lab04TicTacToeTests
{
    public class UnitTest1
    {
        [Fact]
        public void Given_A_Board_Test_For_Winner()
        {
            Board testBoard = new Board();

            bool isWinner = Game.CheckForWinner(testBoard);
            Assert.True(isWinner);
        }
    }
}
