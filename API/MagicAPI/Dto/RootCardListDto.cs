using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MagicAPI.Dto
{
    internal class RootCardListDto
    {
        public List<CardDto> Cards { get; set; }
    }
}