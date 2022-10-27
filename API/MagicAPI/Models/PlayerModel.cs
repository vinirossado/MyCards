using System.Collections;
using System.Collections.Generic;

namespace MagicAPI.Models
{
    public class PlayerModel
    {

        #region Properties

        public int Id { get; set; }
        public string Name { get; private set; }

        public virtual IList<DeckPlayerModel> Decks { get; set; }

        #endregion Properties

        #region Construtors
        protected PlayerModel() { }

        public PlayerModel(int id, string name)
        {
            Id = id;
            Name = name;
        }

        #endregion Construtors


    }
}
