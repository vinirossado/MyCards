using System;
using System.Collections.Generic;

namespace MagicAPI.Models
{
    public class DeckModel
    {

        #region Properties
        public int Id { get; set; }
        public string Name { get; private set; }
        public decimal Price { get; private set; }
        public int PowerLevel { get; private set; }
        public string Guild { get; private set; }
        public DateTime UpdatedAt { get; private set; }

        public virtual IList<DeckCardModel> Cards { get; set; }
        #endregion Properties

        #region Constructors
        protected DeckModel() { }

        public DeckModel(int id, string name, decimal price, int powerLevel, string guild, DateTime updatedAt)
        {
            Id = id;
            Name = name;
            Price = price;
            PowerLevel = powerLevel;
            Guild = guild;
            UpdatedAt = updatedAt;
        }
        #endregion Constructors

        #region Methods

        #endregion Methods

    }
}
