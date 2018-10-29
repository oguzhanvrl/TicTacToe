using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacDeneme
{
    public class GameEngine
    {
       
        public int IndexToPath(int row, int column)
        {
            return (row * 3) + column;
        }

        public List<int> EmptyList(string [] currBoard)
        {
            List<int> emptyPos = new List<int>();
            for (int i = 0; i < 9; i++)
            {
                if (currBoard[i] == " ")
                    emptyPos.Add(i);
            }
            return emptyPos;
        }

        public bool CheckWin(string player,string [] currBoard)
        {         
            if ((currBoard[0] == player && currBoard[1] == player && currBoard[2] == player) ||
               (currBoard[3] == player && currBoard[4] == player && currBoard[5] == player) ||
               (currBoard[6] == player && currBoard[7] == player && currBoard[8] == player) ||
               (currBoard[0] == player && currBoard[3] == player && currBoard[6] == player) ||
               (currBoard[1] == player && currBoard[4] == player && currBoard[7] == player) ||
               (currBoard[2] == player && currBoard[5] == player && currBoard[8] == player) ||
               (currBoard[0] == player && currBoard[4] == player && currBoard[8] == player) ||
               (currBoard[2] == player && currBoard[4] == player && currBoard[6] == player)) { return true; }

            return false;
        }

        public bool CheckTie(string [] currBoard)
        {
            if ((CheckWin("X", currBoard) == false && CheckWin("O", currBoard) == false) && EmptyList(currBoard).Count == 0)
                return true;
            else
                return false;
        }
    }
}
