using UMApplication.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace UMApplication.Application.Common.Interfaces
{
    public interface IApplicationDbContext
    {
        DbSet<Member> Members { get; set; }

        DbSet<Product> Products { get; set; }

        DbSet<AddressInfo> AddressInfos { get; set; }

        DbSet<Supplier> Suppliers { get; set; }
        DbSet<SalesOrder> SalesOrders { get; set; }

        DbSet<SalesOrderItem> SalesOrderItems { get; set; }

        DbSet<Voucher> Vouchers { get; set; }

        DbQuery<UMApplication.Domain.Entities.V_SalesSummary> V_SalesSummaries { get; set; }
        DbQuery<UMApplication.Domain.Entities.V_StockSummary> V_StockSummaries { get; set; }

        DbQuery<UMApplication.Domain.Entities.V_SalesSummaryPerItem> V_SalesSummariesPerItems { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
