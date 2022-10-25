using System;

namespace MagicAPI.Models
{
    public class DeckModel
    {
        #region Properties

        public int Id { get; private set; }

        public string CardId { get; private set; }
        public decimal Price { get; private set; }
        public int PowerLevel { get; private set; }
        public string Guild { get; private set; }
        public DateTime UpdatedAt { get; private set; }

        public virtual CardModel Card { get; set; }

        #endregion Properties

        #region Constructors

        #endregion Constructors
    }
}
