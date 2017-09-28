using System.Collections.Generic;

namespace LoterySefaz.Core
{
    public abstract class Loterry
    {
        public List<int> DrawnNumbers { get; set; }

        public abstract Dictionary<string, string> Draw(Player player);
    }
}
