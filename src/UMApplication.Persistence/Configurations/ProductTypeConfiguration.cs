using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UMApplication.Domain.Entities;

namespace UMApplication.Persistence.Configurations
{
    public class ProductTypeConfiguration : IEntityTypeConfiguration<ProductType>
    {
        public void Configure(EntityTypeBuilder<ProductType> builder)
        {
            builder.Property(e => e.ProductTypeId).HasColumnName("ProductTypeId");
            builder.Property(e => e.Name).HasMaxLength(60).IsRequired();
            builder.Property(e => e.IsActive).IsRequired();
            builder.Property(e => e.CreatedBy).HasMaxLength(60);
            builder.Property(e => e.LastModifiedBy).HasMaxLength(60);
        }
    }
}
