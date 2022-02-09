using UMApplication.Domain.Common;
using System;
using System.Collections.Generic;

namespace UMApplication.Domain.Entities
{
    public class Product : AuditableEntity
    {

        public Product()
        {
            OrderItems = new HashSet<SalesOrderItem>();
        }
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Code { get; set; }
        public string Barcode { get; set; }
        public bool IsActive { get; set; }
        public decimal Hpp { get; set; }
        public float Ppn { get; set; }
        public decimal Margin { get; set; }
        public decimal SellPrice { get; set; }

        public ICollection<SalesOrderItem> OrderItems { get; private set; }

    }
}
