using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public enum BoardField
{
    EMPTY = '.',
    X = 'x',
    O = 'o'
}
namespace tic_tac_toe_oop
{

    public class Board
    {
        BoardField[,] Map { get; set; }
        private int size { get; set; }
        public int GetSize()
        {
            return size;
        }
        public Board(int size)
        {
            this.size = size;
            Map=new BoardField[size,size];
            for(int i=0;i<size;i++)
            {
                for(int j=0;j<size;j++)
                {
                    Map[i,j]=new BoardField();
                }
            }
            CleanBoard();
        }
        public void CleanBoard()
        {
            for(int i=0;i<size;i++)
            { 
                for(int j=0;j<size;j++)
                {
                    Map[i,j]=BoardField.EMPTY;
                }
            }
        }
        public void ShowBoard()
        {
            Console.Write(" ");
            for (int i = 0; i < size; i++)
            {
                Console.Write(" " + i);
            }
            Console.WriteLine();
            for (int i = 0; i < size; i++)
            {
                Console.Write(i + " ");
                for (int j = 0; j < size; j++)
                {
                    Console.Write((char)Map[i, j] + " ");
                }

                Console.Write("\n");
            }
        }
        public void MarkShot(int x,int y,BoardField b)
        {
            Map[x,y]=b;
        }
    }
}
