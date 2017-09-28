using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoterySefaz.Core
{
    public class Bet
    {
        public int BetaId { get; set; }

        public IEnumerable<int> Numbers { get; set; }

        public DateTime BetDate { get; set; }
    }
}
