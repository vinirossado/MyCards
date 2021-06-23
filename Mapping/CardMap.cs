using MagicAPI.Extensions;
using MagicAPI.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
