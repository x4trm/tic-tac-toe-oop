using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tic_tac_toe_oop
{
    public class Bot
    {
        public Bot() : base() { }
        public override string ToString()
        {
            return "Bot";
        }

        public void Move(Board board)
        {
            Random random = new Random();
            board.MarkShot(random.Next(board.GetSize()), random.Next(board.GetSize()), BoardField.X);
        }
    }
}
