using System.Collections.Generic;

namespace LoterySefaz.Core
{
    public class Player
    {
        public Player()
        {
            BetList = new List<Bet>();
        }

        public string Name { get; set; }

        public int AmountBetNumber { get; set; }

        public List<Bet> BetList { get; set; }
    }
}
