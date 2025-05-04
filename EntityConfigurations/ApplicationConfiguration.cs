using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Entites;

namespace EntityConfigurations
{
    public class ApplicationConfiguration : IEntityTypeConfiguration<Application>
    {
        public void Configure(EntityTypeBuilder<Application> builder)
        {
            builder.ToTable("Applications");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.State).IsRequired();
        }
    }
}
