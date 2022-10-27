using MagicAPI.Extensions;
using MagicAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MagicAPI.Mapping
{
    public class DeckCardMap : EntityTypeConfiguration<DeckCardModel>
    {
        public override void Map(EntityTypeBuilder<DeckCardModel> builder)
        {

            builder.ToTable("DeckCard");

            builder.HasKey(x => x.Id);

            builder.HasOne(x => x.Card).WithMany().HasForeignKey(x => x.CardId);

            builder.HasOne(x => x.Deck).WithMany(y => y.Cards).HasForeignKey(x => x.DeckId);

        }
    }
}
