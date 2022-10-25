using MagicAPI.Extensions;
using MagicAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MagicAPI.Mapping
{
    public class CardMap : EntityTypeConfiguration<CardModel>
    {
        public override void Map(EntityTypeBuilder<CardModel> builder)
        {
            builder.ToTable("Card");

            builder.HasKey(x => x.Id);
        }
    }
}
