using UMApplication.Domain.Common;
using System;

namespace UMApplication.Domain.Entities
{
   public class StockIn : AuditableEntity
    {
        public int StockInId { get; set; }

        public string StockInCode { get; set; }

        public int ProductId { get; set; }

        public Product Product { get; set; }

        public int SupplierId { get; set; }

        public Supplier Supplier { get; set; }

        public int Quantity { get; set; }

        public DateTime InputDate { get; set; }
    }
}
