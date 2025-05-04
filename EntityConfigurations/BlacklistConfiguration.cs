using Entites;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityConfigurations
{
    public class BlacklistConfiguration : IEntityTypeConfiguration<Blacklist>
    {
        public void Configure(EntityTypeBuilder<Blacklist> builder)
        {
            builder.ToTable("Blacklists");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Reason).IsRequired().HasMaxLength(255);
        }
    }
}
