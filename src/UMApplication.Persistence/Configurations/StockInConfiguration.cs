using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UMApplication.Domain.Entities;

namespace UMApplication.Persistence.Configurations
{
    public class StockInConfiguration : IEntityTypeConfiguration<StockIn>
    {
        public void Configure(EntityTypeBuilder<StockIn> builder)
        {
            builder.Property(e => e.StockInId).HasColumnName("StockInId");

            builder.HasOne(e => e.Supplier);

            builder.HasOne(e => e.Product);

            builder.Property(e => e.Quantity).IsRequired();

            builder.Property(e => e.CreatedBy).HasMaxLength(60);

            builder.Property(e => e.LastModifiedBy).HasMaxLength(60);


        }
    }
}
