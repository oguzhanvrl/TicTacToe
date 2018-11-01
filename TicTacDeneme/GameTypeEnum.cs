using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacDeneme
{
    public class GameTypeEnum
    {
        public enum GameType
        {
            PvP = 0,
            PvAIX,
            Host,
            Client,
            PvPTimed,
            PvAIO
        };
    }
}
