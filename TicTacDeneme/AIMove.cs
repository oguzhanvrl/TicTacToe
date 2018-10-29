using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacDeneme
{
    public class AIMove
    {
        public PvP Game { get; set; }

        private GameEngine ge { get; set; }

        public string AI { get; set; }

        public string Player { get; set; }

        public AIMove(string AI,string Player)
        {
            this.AI = AI;
            this.Player = Player;
            ge = new GameEngine();
        }
       
        public int CheckWinningMove(string player, string[] board)
        {
            int move = -1;
            List<int> emptyList = ge.EmptyList(board);
            int[] empty = emptyList.ToArray<int>();
            for (int i = 0; i < empty.Length; i++)
            {
                move = -1;
                board[empty[i]] = player;

                if (ge.CheckWin(player,board))
                {
                    board[empty[i]] = " ";
                    move = empty[i];
                    break;
                }
                board[empty[i]] = " ";
            }
            return move;
        }
    }
}
