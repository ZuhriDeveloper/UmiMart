using UMApplication.Domain.Common;
using System;

namespace UMApplication.Domain.Entities
{
    public class ProductType : AuditableEntity
    {
        public int ProductTypeId { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }
    }
}
