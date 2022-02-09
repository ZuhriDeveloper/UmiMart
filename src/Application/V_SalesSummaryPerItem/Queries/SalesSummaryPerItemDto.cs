using AutoMapper;
using UMApplication.Application.Common.Mappings;
using UMApplication.Domain.Entities;
using System;

namespace UMApplication.Application.V_SalesSummaryPerItem.Queries
{
   public class SalesSummaryPerItemDto : IMapFrom<UMApplication.Domain.Entities.V_SalesSummaryPerItem>
    {
        public DateTime Tgl_Transaksi { get; set; }
        public string Code { get; set; }
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int Qty { get; set; }
        public decimal Sales { get; set; }
        public decimal Hpp { get; set; }
        public int Tax { get; set; }
        public decimal SalesNet { get; set; }
        public decimal Margin { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<UMApplication.Domain.Entities.V_SalesSummaryPerItem, SalesSummaryPerItemDto>() ;
        }
    }
}
