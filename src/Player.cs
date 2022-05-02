using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tic_tac_toe_oop
{
    public abstract class Player
    {

        public abstract void Move(Board board);
        public bool Win(Board board)
        {
            if(Check(board, 0, 0, 1, 1)==true)
            {
                return true;
            }
            if(Check(board, 0, board.GetSize() - 1, 1, -1)==true)
            {
                return true;
            }
            for (int i = 0; i < board.GetSize(); i++)
            {
                if (Check(board, i, 0, 0, 1))
                    return true;
            }
            for (int i = 0; i < board.GetSize(); i++)
            {
                if (Check(board, 0, i, 0, 1))
                    return true;
            }
            for(int i=0;i< board.GetSize(); i++)
            {
                for(int j = 0; j < board.GetSize(); j++)
                {
                    if(board.map[i,j] == BoardField.EMPTY)
                    {
                        return false;
                    }
                }
            }
            return false;


            
        }
        public bool Check(Board board,int row,int col,int dr,int dc)
        {
            BoardField field=board.map[row,col];
            if(field==BoardField.EMPTY)
            {
                return false;
            }
            row += dr;
            col += dc;
            while(row>=0 && row<board.GetSize() && col>=0 && col<board.GetSize())
            {
                if(board.map[row,col]!=field)
                {
                    return false;
                }
                row += dr;
                col += dc;
            }
            return true;
        }

    }
}
