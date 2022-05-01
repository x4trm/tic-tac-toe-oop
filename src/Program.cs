using System;

namespace tic_tac_toe_oop
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Board board = new Board(3);
            board.ShowBoard();
            Human human = new Human();
            human.Move(1, 2,board);
            board.ShowBoard();
            Bot bot = new Bot();
            bot.Move(board);
            board.ShowBoard();  
            
        }
    }
}
