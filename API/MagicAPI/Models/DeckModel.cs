using System;
using System.Collections.Generic;

namespace MagicAPI.Models
{
    public class DeckModel : Entity<DeckModel, int>
    {

        #region Properties
        public int Id { get; set; }
        public string Name { get; private set; }
        public decimal Price { get; private set; }
        public int PowerLevel { get; private set; }
        public string Guild { get; private set; }
        public DateTime? UpdatedAt { get; private set; }

        public virtual IList<DeckCardModel>? DeckCards { get; set; }
        #endregion Properties

        #region Constructors
        public DeckModel() { }

        public DeckModel(string name, decimal price, int powerLevel, string guild)
        {
            Name = name;
            Price = price;
            PowerLevel = powerLevel;
            Guild = guild;
            UpdatedAt = DateTime.UtcNow;

        }
        #endregion Constructors

        #region Methods
        private void Update(int id, string name, decimal price, int powerLevel, string guild)
        {
            Id = id;
            Name = name;
            Price = price;
            PowerLevel = powerLevel;
            Guild = guild;
            UpdatedAt = DateTime.UtcNow;
        }
        #endregion Methods

    }
}
