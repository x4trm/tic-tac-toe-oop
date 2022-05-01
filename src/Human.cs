using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tic_tac_toe_oop
{
    public class Human
    {
        public Human() : base() { }
        public override string ToString()
        {
            return "Human";
        }

        public void Move(int x, int y,Board board)
        {
            board.MarkShot(x, y, BoardField.O);
        }
    }
}
