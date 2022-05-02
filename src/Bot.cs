using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tic_tac_toe_oop
{
    public class Bot:Player
    {
        public Bot() : base() { }
        public override string ToString()
        {
            return "Bot";
        }

        public override void Move(Board board)
        {
            Random random = new Random();
            int x, y;
            do
            {
                x = random.Next(board.GetSize());
                y = random.Next(board.GetSize());

            } while (board.map[x, y] != BoardField.EMPTY);
            board.MarkShot(x,y,BoardField.X);
            
            
        }

    }
}
