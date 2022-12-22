using MagicAPI.Request;
using System.Collections.Generic;

namespace MagicAPI.Dto
{
    public class DeckDto
    {
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int PowerLevel { get; set; }
        public string Guild { get; set; }

        public virtual IEnumerable<RegisterCardRequest>? Cards { get; set; } = null;
        public virtual IEnumerable<string>? CardsUrl { get; set; } = null;
    }
}
