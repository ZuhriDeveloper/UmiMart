using UMApplication.Domain.Common;
using System;
using System.Collections.Generic;

namespace UMApplication.Domain.Entities
{
    public class SalesOrder : AuditableEntity
    {
        public SalesOrder()
        {
            Status = "BARU";
            Items = new HashSet<SalesOrderItem>();
            PaidDate = new DateTime(1900, 1, 1);
        }
        public int SalesOrderId { get; set; }

        public string SalesOrderNumber { get; set; }

        public string Status { get; set; }

        public DateTime SalesOrderDate { get; set; }

        public DateTime SalesOrderDueDate { get; set; }

        public DateTime PaidDate { get; set; }

        public int SupplierId { get; set; }

        public Supplier Supplier { get; set; }

        public decimal GrandTotal { get; set; }

        public ICollection<SalesOrderItem> Items { get; private set; }
    }
}
