using MagicAPI.Extensions;
using MagicAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MagicAPI.Mapping
{
    public class DeckMap : EntityTypeConfiguration<DeckModel>
    {
        public override void Map(EntityTypeBuilder<DeckModel> builder)
        {

            builder.ToTable("Deck");
            builder.HasKey(x => x.Id);

        }
    }
}
