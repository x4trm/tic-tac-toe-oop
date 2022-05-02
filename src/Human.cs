using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tic_tac_toe_oop
{
    public class Human:Player
    {
        public Human() : base() { }
        public override string ToString()
        {
            return "Human";
        }

        public override void Move(Board board)
        {
            int x, y;
            do
            {
                Console.WriteLine("Your turn:");
                Console.Write("x: ");
                x = int.Parse(Console.ReadLine());
                Console.Write("y: ");
                y = int.Parse(Console.ReadLine());
            } while (x < 0 || x >= board.GetSize() || y < 0 || y >= board.GetSize() || board.map[x, y] != BoardField.EMPTY);
            board.MarkShot(x, y, BoardField.O);
        }
    }
}
