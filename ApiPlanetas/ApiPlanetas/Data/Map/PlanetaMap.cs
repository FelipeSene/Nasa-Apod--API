using ApiPlanetas.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace ApiPlanetas.Data.Map
{
    public class PlanetaMap : IEntityTypeConfiguration<PlanetaModel>
    {
        public void Configure(EntityTypeBuilder<PlanetaModel> builder)
        {
            builder.HasKey(y => y.Id);
            builder.Property(y => y.Name).IsRequired().HasMaxLength(250);
            builder.Property(y => y.Classification).IsRequired().HasMaxLength(50);
        }
    }
}
