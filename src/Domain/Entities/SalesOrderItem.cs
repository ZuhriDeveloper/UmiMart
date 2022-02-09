using UMApplication.Domain.Common;
using System;

namespace UMApplication.Domain.Entities
{
   public class SalesOrderItem : AuditableEntity
    {
        public int SalesOrderId { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public SalesOrder SalesOrder { get; set; }
    }
}
