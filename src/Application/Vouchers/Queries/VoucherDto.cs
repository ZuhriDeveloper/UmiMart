using AutoMapper;
using UMApplication.Application.Common.Mappings;
using UMApplication.Domain.Entities;
using System;
using UMApplication.Domain.Extension;

namespace UMApplication.Application.Vouchers.Queries
{
    public class VoucherDto : IMapFrom<Voucher>
    {
        public int VoucherId { get; set; }
        public string VoucherCode { get; set; }
        public string Status { get; set; }
        public string No_Faktur { get; set; }
        public string Nominal { get; set; }
        public DateTime ValidFrom { get; set; }

        public string ValidFromString { get; set; }
        public DateTime? ValidTo { get; set; }

        public string ValidToString { get; set; }
        public DateTime? UsageDate { get; set; }

        public string UsageDateString { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Voucher, VoucherDto>()
                  .ForMember(m => m.Nominal, opt => opt.MapFrom(s => s.Nominal.ToString("N0")))
                  .ForMember(m => m.ValidFromString, opt => opt.MapFrom(s => s.ValidFrom.ToShortDateString()))
                  .ForMember(m => m.ValidToString, opt => opt.MapFrom(s => s.ValidTo.ToDateString("dd-mm-yy")))
                  .ForMember(m => m.UsageDateString, opt => opt.MapFrom(s => s.UsageDate.ToDateString("dd-mm-yy")))
                  ;
        }
    }
}
