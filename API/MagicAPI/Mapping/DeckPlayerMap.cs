using MagicAPI.Extensions;
using MagicAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MagicAPI.Mapping
{
    public class DeckPlayerMap : EntityTypeConfiguration<DeckPlayerModel>
    {
        public override void Map(EntityTypeBuilder<DeckPlayerModel> builder)
        {
            builder.ToTable("DeckPlayer");

            builder.HasKey(x => x.Id);

            //builder.HasOne(x => x.Deck).WithMany().HasForeignKey(x => x.DeckId);

            //builder.HasOne(x => x.Player).WithMany(y => y.Decks).HasForeignKey(x => x.PlayerId);

        }
    }
}
