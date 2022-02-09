using UMApplication.Domain.Common;
using System;

namespace UMApplication.Domain.Entities
{
   public class Stock : AuditableEntity
    {
        public int StockId { get; set; }

        public int ProductId { get; set; }

        public Product Product { get; set; }

        public string Status { get; set; }

        public int Quantity { get; set; }

        public DateTime InputDate { get; set; }
    }
}
