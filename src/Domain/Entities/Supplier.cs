using UMApplication.Domain.Common;
using System;
using System.Collections.Generic;

namespace UMApplication.Domain.Entities
{
    public class Supplier : AuditableEntity
    {

        public Supplier()
        {
            Orders = new HashSet<SalesOrder>();
        }
        public int SupplierId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string ContactPerson { get; set; }
        public string Phone { get; set; }

        public string Handphone { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }

        public ICollection<SalesOrder> Orders { get; private set; }
    }
}
