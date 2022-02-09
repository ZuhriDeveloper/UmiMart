using Microsoft.EntityFrameworkCore;

namespace UMApplication.Persistence
{
    public class UMApplicationDbContextFactory : DesignTimeDbContextFactoryBase<UMApplicationDBContext>
    {
        protected override UMApplicationDBContext CreateNewInstance(DbContextOptions<UMApplicationDBContext> options)
        {
            return new UMApplicationDBContext(options);
        }
    }
}
