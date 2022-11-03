namespace MagicAPI.Models
{
    public class DeckCardModel
    {

        #region Properties
        public int Id { get; set; }
        public int DeckId { get; private set; }
        public string CardId { get; private set; }

        public virtual DeckModel Deck { get; set; } = null;
        public virtual CardModel Card { get; set; } = null;

        #endregion Properties

        #region Constructors
        public DeckCardModel(int deckId, string cardId)
        {
            DeckId = deckId;
            CardId = cardId;
        }
        #endregion Constructors
    }
}
