using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UMApplication.Domain.Entities;

namespace UMApplication.Persistence.Configurations
{
    public class VoucherConfiguration : IEntityTypeConfiguration<Voucher>
    {
        public void Configure(EntityTypeBuilder<Voucher> builder)
        {
            builder.Property(e => e.VoucherId).HasColumnName("VoucherId");

            builder.Property(e => e.VoucherCode).HasMaxLength(30);



        }
    }
}
