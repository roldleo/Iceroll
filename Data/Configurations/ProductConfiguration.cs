using IceRoll.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Rollice.Data{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product>builder1)
        {
            builder1.Property(p => p.ImageName).HasColumnName("ImageFileName");
        }
    }
    
}