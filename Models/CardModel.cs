using MagicAPI.Dto;
using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace MagicAPI.Models
{
    public class CardModel
    {

        #region Properties

        [JsonPropertyName("artist")]
        public string Artist { get; private set; }

        [JsonPropertyName("border")]
        public string Border { get; private set; }

        [JsonPropertyName("cmc")]
        public float? Cmc { get; private set; }

        //[JsonPropertyName("colorIdentity")]
        //public string[] ColorIdentity { get; private set; }

        //[JsonPropertyName("colors")]
        //public string[] Colors { get; private set; }

        [JsonPropertyName("flavor")]
        public string Flavor { get; private set; }

        //[JsonPropertyName("foreignNames")]
        //public ForeignNameDto[] ForeignNames { get; private set; }

        [JsonPropertyName("hand")]
        public int? Hand { get; private set; }

        [JsonPropertyName("id")]
        public string Id { get; private set; }

        [JsonPropertyName("imageUrl")]
        public string ImageUrl { get; private set; }

        [JsonPropertyName("layout")]
        public string Layout { get; private set; }

        //[JsonPropertyName("legalities")]
        //public LegalityDto[] Legalities { get; private set; }

        [JsonPropertyName("life")]
        public int? Life { get; private set; }

        [JsonPropertyName("loyalty")]
        public string Loyalty { get; private set; }

        [JsonPropertyName("manaCost")]
        public string ManaCost { get; private set; }

        [JsonPropertyName("multiverseid")]
        public string MultiverseId { get; private set; }

        [JsonPropertyName("name")]
        public string Name { get; private set; }

        //[JsonPropertyName("names")]
        //public string[] Names { get; private set; }

        [JsonPropertyName("number")]
        public string Number { get; private set; }

        [JsonPropertyName("originalText")]
        public string OriginalText { get; private set; }

        [JsonPropertyName("originalType")]
        public string OriginalType { get; private set; }

        [JsonPropertyName("power")]
        public string Power { get; private set; }

        //[JsonPropertyName("printings")]
        //public string[] Printings { get; private set; }

        [JsonPropertyName("rarity")]
        public string Rarity { get; private set; }

        [JsonPropertyName("releaseDate")]
        public string ReleaseDate { get; private set; }

        [JsonPropertyName("reserved")]
        public bool? Reserved { get; private set; }

        //[JsonPropertyName("rulings")]
        //public RulingDto[] Rulings { get; private set; }

        [JsonPropertyName("set")]
        public string Set { get; private set; }

        [JsonPropertyName("setName")]
        public string SetName { get; private set; }

        [JsonPropertyName("source")]
        public string Source { get; private set; }

        [JsonPropertyName("starter")]
        public bool? Starter { get; private set; }

        //[JsonPropertyName("subtypes")]
        //public string[] SubTypes { get; private set; }

        //[JsonPropertyName("supertypes")]
        //public string[] SuperTypes { get; private set; }

        [JsonPropertyName("text")]
        public string Text { get; private set; }

        [JsonPropertyName("timeshifted")]
        public bool? Timeshifted { get; private set; }

        [JsonPropertyName("toughness")]
        public string Toughness { get; private set; }

        [JsonPropertyName("type")]
        public string Type { get; private set; }

        //[JsonPropertyName("types")]
        //public string[] Types { get; private set; }

        //[JsonPropertyName("variations")]
        //public string[] Variations { get; private set; }

        [JsonPropertyName("watermark")]
        public string Watermark { get; private set; }

        #endregion Properties

        #region Constructors
        protected CardModel() { }
        public CardModel(string artist, string border, float? cmc, string flavor, int? hand, string id, string imageUrl, string layout, int? life, string loyalty, string manaCost, string multiverseId, string name, string number, string originalText, string originalType, string power, string rarity, string releaseDate, bool? reserved, string set, string setName, string source, bool? starter, string text, bool? timeshifted, string toughness, string type, string watermark)
        {
            Artist = artist;
            Border = border;
            Cmc = cmc;
            Flavor = flavor;
            Hand = hand;
            Id = id;
            ImageUrl = imageUrl;
            Layout = layout;
            Life = life;
            Loyalty = loyalty;
            ManaCost = manaCost;
            MultiverseId = multiverseId;
            Name = name;
            Number = number;
            OriginalText = originalText;
            OriginalType = originalType;
            Power = power;
            Rarity = rarity;
            ReleaseDate = releaseDate;
            Reserved = reserved;
            Set = set;
            SetName = setName;
            Source = source;
            Starter = starter;
            Text = text;
            Timeshifted = timeshifted;
            Toughness = toughness;
            Type = type;
            Watermark = watermark;
        }
        #endregion Constructors

    }
}
