using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UMApplication.Domain.Entities;

namespace UMApplication.Persistence.Configurations
{
   public class SalesOrderConfiguration : IEntityTypeConfiguration<SalesOrder>
    {
        public void Configure(EntityTypeBuilder<SalesOrder> builder)
        {
            builder.Property(e => e.SalesOrderId).HasColumnName("SalesOrderId");

            builder.Property(e => e.SalesOrderNumber).HasMaxLength(60);

            builder.Property(e => e.SalesOrderDate).HasColumnType("datetime");

            builder.Property(e => e.SalesOrderDueDate).HasColumnType("datetime");

            builder.Property(e => e.PaidDate).HasColumnType("datetime");

            builder.Property(e => e.GrandTotal).HasColumnType("decimal(18,2)");

            builder.HasOne(s => s.Supplier)
                .WithMany(o => o.Orders)
                .HasForeignKey(s => s.SupplierId)
                .HasConstraintName("FK_SalesOrders_Suppliers");
        }
    }
}
