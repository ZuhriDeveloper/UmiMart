using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UMApplication.Domain.Entities;

namespace UMApplication.Persistence.Configurations
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(e => e.ProductId).HasColumnName("ProductId");
            builder.Property(e => e.Name).HasMaxLength(200).IsRequired();
            builder.Property(e => e.Code).HasMaxLength(60);
            builder.Property(e => e.Barcode).HasMaxLength(30);
            builder.Property(e => e.IsActive).IsRequired();
            builder.Property(e => e.CreatedBy).HasMaxLength(60);
            builder.Property(e => e.LastModifiedBy).HasMaxLength(60);
        }
    }
}
