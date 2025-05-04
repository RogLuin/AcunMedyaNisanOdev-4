using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entites;

namespace EntityConfigurations
{
    namespace EntityConfigurations
    {
        public class BootcampConfiguration : IEntityTypeConfiguration<Bootcamp>
        {
            public void Configure(EntityTypeBuilder<Bootcamp> builder)
            {
                builder.ToTable("Bootcamps");
                builder.HasKey(x => x.Id);
                builder.Property(x => x.Name).IsRequired().HasMaxLength(100);
                builder.Property(x => x.StartDate).IsRequired();
                builder.Property(x => x.EndDate).IsRequired();
                builder.Property(x => x.State).IsRequired();
            }
        }
    }
}
