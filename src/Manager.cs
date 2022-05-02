using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tic_tac_toe_oop
{
    public class Manager
    {
        public Player player1;
        public Player player2;
        public Player winner;
        public Board board;
        public Manager()
        {
            player1 = new Human();
            player2 = new Bot();
            board = new Board(3);
        }
        public bool GameOver()
        {
            if(player1.Win(board))
            {
                winner = player1;
                return true;
            }
            if(player2.Win(board))
            {
                winner = player2;
                return true;
            }
            return false;
        }
        public void Game()
        {
            bool flag = true;
            bool flag2 = true;
            while(flag)
            {
                if(flag2)
                {
                    Console.WriteLine("Board:");
                    board.ShowBoard();
                    player1.Move(board);
                    if(GameOver()==true)
                    {
                        flag = false;
                    }
                    flag2 = false;

                }
                else
                {
                    player2.Move(board);
                    if(GameOver()==true)
                    {
                        flag=false;
                    }
                    flag2=true;
                }
            }
            Console.WriteLine("Winner: " + winner.ToString());
            Console.WriteLine("Press any key...");
        }
    }
}
