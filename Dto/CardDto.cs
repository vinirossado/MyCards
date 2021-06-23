using System.Text.Json.Serialization;

namespace MagicAPI.Dto
{
    internal class CardDto
    {
        public string Artist { get; set; }

        public string Border { get; set; }

        public float? Cmc { get; set; }

        public string[] ColorIdentity { get; set; }

        public string[] Colors { get; set; }

        public string Flavor { get; set; }

        public ForeignNameDto[] ForeignNames { get; set; }

        public int? Hand { get; set; }

        public string Id { get; set; }

        public string ImageUrl { get; set; }

        public string Layout { get; set; }

        public LegalityDto[] Legalities { get; set; }

        public int? Life { get; set; }

        public string Loyalty { get; set; }

        public string ManaCost { get; set; }

        public string MultiverseId { get; set; }

        public string Name { get; set; }

        public string[] Names { get; set; }

        public string Number { get; set; }

        public string OriginalText { get; set; }

        public string OriginalType { get; set; }

        public string Power { get; set; }

        public string[] Printings { get; set; }

        public string Rarity { get; set; }

        public string ReleaseDate { get; set; }

        public bool? Reserved { get; set; }

        public RulingDto[] Rulings { get; set; }

        public string Set { get; set; }

        public string SetName { get; set; }

        public string Source { get; set; }

        public bool? Starter { get; set; }

        public string[] SubTypes { get; set; }

        public string[] SuperTypes { get; set; }

        public string Text { get; set; }

        public bool? Timeshifted { get; set; }

        public string Toughness { get; set; }

        public string Type { get; set; }

        public string[] Types { get; set; }

        public string[] Variations { get; set; }

        public string Watermark { get; set; }
    }
}