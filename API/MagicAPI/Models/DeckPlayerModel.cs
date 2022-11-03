namespace MagicAPI.Models
{
    public class DeckPlayerModel
    {
        #region Properties
        public int Id { get; set; }
        public int PlayerId { get; private set; }
        public int DeckId { get; private set; }

        public virtual PlayerModel Player { get; private set; }
        public virtual DeckModel Deck { get; private set; }
        #endregion Properties

        #region Constructors

        protected DeckPlayerModel()
        {

        }
        public DeckPlayerModel(int id, int playerId, int deckId)
        {
            Id = id;
            PlayerId = playerId;
            DeckId = deckId;
        }

        #endregion Constructors

        #region Methods

        #endregion Methods

    }
}
