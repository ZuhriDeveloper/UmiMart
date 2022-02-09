using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UMApplication.Domain.Entities;


namespace UMApplication.Persistence.Configurations
{
    public class SupplierConfiguration : IEntityTypeConfiguration<Supplier>
    {
        public void Configure(EntityTypeBuilder<Supplier> builder)
        {
            builder.Property(e => e.SupplierId).HasColumnName("SupplierId");
            builder.Property(e => e.Name).HasMaxLength(60).IsRequired();
            builder.Property(e => e.Address).HasMaxLength(100);
            builder.Property(e => e.Email).HasMaxLength(30);
            builder.Property(e => e.ContactPerson).HasMaxLength(30);
            builder.Property(e => e.Phone).HasMaxLength(30);
            builder.Property(e => e.IsActive).IsRequired();
            builder.Property(e => e.CreatedBy).HasMaxLength(60);
            builder.Property(e => e.LastModifiedBy).HasMaxLength(60);
        }
    }
}
