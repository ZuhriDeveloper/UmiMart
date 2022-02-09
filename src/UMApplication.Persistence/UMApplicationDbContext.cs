using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using UMApplication.Application.Common.Interfaces;
using UMApplication.Common;
using UMApplication.Domain.Entities;
using UMApplication.Domain.Common;

namespace UMApplication.Persistence
{
    public class UMApplicationDBContext : DbContext, IApplicationDbContext
    {
        private readonly ICurrentUserService _currentUserService;
        private readonly IDateTime _dateTime;

        public UMApplicationDBContext(DbContextOptions<UMApplicationDBContext> options)
            : base(options)
        {
        }

        public UMApplicationDBContext(
            DbContextOptions<UMApplicationDBContext> options,
            ICurrentUserService currentUserService,
            IDateTime dateTime)
            : base(options)
        {
            _currentUserService = currentUserService;
            _dateTime = dateTime;
        }


        public DbSet<Product> Products { get; set; }

        public DbSet<Member> Members { get; set; }
        public DbSet<AddressInfo> AddressInfos { get; set; }

        public DbSet<Supplier> Suppliers { get; set; }

        public DbSet<ProductType> ProductTypes { get; set; }

        public DbSet<SalesOrder> SalesOrders { get; set; }

        public DbSet<SalesOrderItem> SalesOrderItems { get; set; }

        public DbSet<Voucher> Vouchers { get; set; }

        public DbQuery<V_SalesSummary> V_SalesSummaries { get; set; }

        public DbQuery<V_StockSummary> V_StockSummaries { get; set; }

        public DbQuery<V_SalesSummaryPerItem> V_SalesSummariesPerItems { get; set; }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = new CancellationToken())
        {
            foreach (var entry in ChangeTracker.Entries<AuditableEntity>())
            {
                switch (entry.State)
                {
                    case EntityState.Added:
                        //entry.Entity.CreatedBy = _currentUserService.UserId;
                        entry.Entity.Created = _dateTime.Now;
                        break;
                    case EntityState.Modified:
                        //entry.Entity.LastModifiedBy = _currentUserService.UserId;
                        entry.Entity.LastModified = _dateTime.Now;
                        break;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Query<V_SalesSummary>().ToView("V_SalesSummary");
            modelBuilder.Query<V_StockSummary>().ToView("V_StockSummary");
            modelBuilder.Query<V_SalesSummaryPerItem>().ToView("V_SalesSummaryPerItem");
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(UMApplicationDBContext).Assembly);
        }
    }
}
