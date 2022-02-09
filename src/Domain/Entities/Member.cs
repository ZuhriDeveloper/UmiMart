using UMApplication.Domain.Common;
using System;

namespace UMApplication.Domain.Entities
{
    public class Member : AuditableEntity
    {
        public int MemberId { get; set; }
        public string FullName { get; set; }
        public string MembershipNumber { get; set; }
        public string CardNumber { get; set; }
        public string Address { get; set; }
        public bool IsActive { get; set; }
        public decimal Plafon { get; set; }

        public decimal DiscountFlat { get; set; }
        public float DiscountRate { get; set; }


    }
}
