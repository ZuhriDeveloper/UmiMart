using MediatR;
using System;
namespace UMApplication.Application.Vouchers.Commands.UpsertVoucher
{
    public class UpsertVoucherCommand : IRequest<int>
    {
        public UpsertVoucherCommand()
        {
            Status = "AKTIF";
            ValidFromString = DateTime.Now.ToShortDateString();
        }
        public int VoucherId { get; set; }
        public string VoucherCode { get; set; }
        public string Status { get; set; }
        public string No_Faktur { get; set; }
        public decimal Nominal { get; set; }
        public DateTime ValidFrom { get; set; }
        public string ValidFromString { get; set; }
        public DateTime? ValidTo { get; set; }

        public string ValidToString { get; set; }
        public DateTime? UsageDate { get; set; }

        public string UsageDateString { get; set; }
    }
}
