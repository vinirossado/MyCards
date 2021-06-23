using System.Text.Json.Serialization;

namespace MagicAPI.Dto
{
    public class ForeignNameDto
    {
        public string Language { get; set; }
        public int? MultiverseId { get; set; }
        public string Name { get; set; }
    }
}