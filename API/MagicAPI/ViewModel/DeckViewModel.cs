using MagicAPI.Dto;
using System.Collections;
using System.Collections.Generic;

namespace MagicAPI.ViewModel
{
    public class DeckViewModel
    {
        public int Id { get; set; }
        public IList<DeckDto> Cards { get; set; }
    }
}
