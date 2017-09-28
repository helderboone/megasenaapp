using System.Collections.Generic;

namespace LoterySefaz.Core
{
    public interface IDraw
    {
        Dictionary<string, string> Draw(Player player);

        List<int> DrawnNumbers { get; set; }
    }
}
