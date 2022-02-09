using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UMApplication.Domain.Entities;

namespace UMApplication.Persistence.Configurations
{
    public class MemberConfiguration : IEntityTypeConfiguration<Member>
    {
        public void Configure(EntityTypeBuilder<Member> builder)
        {
            builder.Property(e => e.MemberId).HasColumnName("MemberId");

            builder.Property(e => e.FullName).HasMaxLength(60).IsRequired();

            builder.Property(e => e.Address).HasMaxLength(200);

            builder.Property(e => e.MembershipNumber).HasMaxLength(30);

            builder.Property(e => e.CardNumber).HasMaxLength(30);

            builder.Property(e => e.IsActive).IsRequired();

            builder.Property(e => e.CreatedBy).HasMaxLength(60);

            builder.Property(e => e.LastModifiedBy).HasMaxLength(60);

            builder.Property(e => e.DiscountRate).HasColumnType("decimal(18,2)");

        }
    }
}
