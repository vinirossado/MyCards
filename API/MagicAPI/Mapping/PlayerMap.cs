using MagicAPI.Extensions;
using MagicAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace MagicAPI.Mapping
{
    public class PlayerMap : EntityTypeConfiguration<PlayerModel>
    {
        public override void Map(EntityTypeBuilder<PlayerModel> builder)
        {
            builder.ToTable("Player");

            builder.HasKey(x => x.Id);
        }
    }
}
