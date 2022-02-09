using AutoMapper;
using UMApplication.Application.Common.Mappings;
using UMApplication.Domain.Entities;
using System;

namespace UMApplication.Application.V_SalesSummary.Queries
{
    public class SalesSummaryDto : IMapFrom<UMApplication.Domain.Entities.V_SalesSummary>
    {
        public string No_Faktur { get; set; }
        public DateTime Tgl_Transaksi { get; set; }
        public decimal Total_Bayar { get; set; }
        public decimal Bayar { get; set; }
        public decimal Diskon { get; set; }

        public decimal TotalHpp { get; set; }

        public decimal Kembali { get; set; }
        public string Nama_Kasir { get; set; }
        public string Nama_Pelanggan { get; set; }

        public string Metode_Pembayaran { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<UMApplication.Domain.Entities.V_SalesSummary, SalesSummaryDto>();
        }
    }
}
