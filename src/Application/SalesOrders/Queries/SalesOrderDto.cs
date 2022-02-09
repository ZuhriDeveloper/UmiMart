using AutoMapper;
using UMApplication.Application.Common.Mappings;
using UMApplication.Domain.Entities;
using System;
using System.Globalization;

namespace UMApplication.Application.SalesOrders.Queries
{
    public class SalesOrderDto : IMapFrom<SalesOrder>
    {
        public int Id { get; set; }
        public string NomorSalesOrder { get; set; }

        public DateTime TanggalPesan { get; set; }

        public string TanggalPesanString { get; set; }

        public DateTime TanggalJatuhTempo { get; set; }

        public string TanggalJatuhTempoString { get; set; }

        public string TanggalBayar { get; set; }

        public int SupplierId { get; set; }
        public string NamaSupplier { get; set; }

        public decimal GrandTotal { get; set; }

        public string GrandTotalString { get; set; }

        public string Status { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<SalesOrder, SalesOrderDto>()
                .ForMember(m => m.Id, opt => opt.MapFrom(s => s.SalesOrderId))
                .ForMember(m => m.NomorSalesOrder, opt => opt.MapFrom(s => s.SalesOrderNumber))
                .ForMember(m => m.TanggalPesan, opt => opt.MapFrom(s => s.SalesOrderDate))
                .ForMember(m => m.TanggalJatuhTempo, opt => opt.MapFrom(s => s.SalesOrderDueDate))
                .ForMember(m => m.NamaSupplier, opt => opt.MapFrom(s => s.Supplier.Name))
                .ForMember(m => m.TanggalBayar, opt => opt.MapFrom(s => s.PaidDate.ToString("dd-M-yyyy")))
                .ForMember(m => m.TanggalPesanString, opt => opt.MapFrom(s => s.SalesOrderDate.ToString("dd-M-yyyy")))
                .ForMember(m => m.TanggalJatuhTempoString, opt => opt.MapFrom(s => s.SalesOrderDueDate.ToString("dd-M-yyyy")))
                .ForMember(m => m.GrandTotalString, opt => opt.MapFrom(s => s.GrandTotal.ToString("N0", CultureInfo.CurrentCulture)))
                ;
        }
    }
}
