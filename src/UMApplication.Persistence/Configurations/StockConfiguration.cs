using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UMApplication.Domain.Entities;

namespace UMApplication.Persistence.Configurations
{
    public class StockConfiguration : IEntityTypeConfiguration<Stock>
    {
        public void Configure(EntityTypeBuilder<Stock> builder)
        {
            builder.Property(e => e.StockId).HasColumnName("StockId");

            builder.Property(e => e.Status).HasMaxLength(3);

            builder.HasOne(e => e.Product);

            builder.Property(e => e.Quantity).IsRequired();

            builder.Property(e => e.CreatedBy).HasMaxLength(60);

            builder.Property(e => e.LastModifiedBy).HasMaxLength(60);


        }
    }
}
