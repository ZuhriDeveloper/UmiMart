using UMApplication.Domain.Common;
using System;
using System.Collections.Generic;

namespace UMApplication.Domain.Entities
{
    public class Voucher : AuditableEntity
    {
        public int VoucherId { get; set; }
        public string VoucherCode { get; set; }
        public string Status { get; set; }
        public string No_Faktur { get; set; }
        public decimal Nominal { get; set; }
        public DateTime ValidFrom { get; set; }
        public DateTime? ValidTo { get; set; }
        public DateTime? UsageDate { get; set; }
    }
}
