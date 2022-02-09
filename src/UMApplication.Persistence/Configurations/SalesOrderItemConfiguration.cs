using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UMApplication.Domain.Entities;

namespace UMApplication.Persistence.Configurations
{
   public class SalesOrderItemConfiguration : IEntityTypeConfiguration<SalesOrderItem>
    {
        public void Configure(EntityTypeBuilder<SalesOrderItem> builder)
        {
            builder.HasKey(e => new { e.SalesOrderId, e.ProductId });

            builder.Property(e => e.SalesOrderId).HasColumnName("SalesOrderId");

            builder.Property(e => e.ProductId).HasColumnName("ProductId");

            builder.Property(e => e.Quantity).HasDefaultValueSql("((0))");

            builder.Property(e => e.UnitPrice).HasColumnType("decimal(18,2)");

            builder.HasOne(d => d.SalesOrder)
               .WithMany(p => p.Items)
               .HasForeignKey(d => d.SalesOrderId)
               .OnDelete(DeleteBehavior.ClientSetNull)
               .HasConstraintName("FK_SalesOrderItem_SalesOrder");

            builder.HasOne(d => d.Product)
                .WithMany(p => p.OrderItems)
                .HasForeignKey(d => d.ProductId)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_SalesOrderItem_Product");
        }
    }
}
