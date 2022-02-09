using System;
using System.Globalization;
using AutoMapper;
using UMApplication.Application.Common.Mappings;


namespace UMApplication.Application.V_StockSummary.Queries
{
    public class StockSummaryDto : IMapFrom<UMApplication.Domain.Entities.V_StockSummary>
    {
        public int ProductId { get; set; }

        public string PLU { get; set; }
        public string ProductName { get; set; }
        public decimal Hpp { get; set; }
        public string HppString { get; set; }

        public decimal SellPrice { get; set; }
        public string SellPriceString { get; set; }
        public int Quantity { get; set; }
        public decimal Total { get; set; }
        public string TotalString { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<UMApplication.Domain.Entities.V_StockSummary, StockSummaryDto>()
                 .ForMember(m => m.HppString, opt => opt.MapFrom(s => s.Hpp.ToString("N0", CultureInfo.CurrentCulture)))
                 .ForMember(m => m.SellPriceString, opt => opt.MapFrom(s => s.SellPrice.ToString("N0", CultureInfo.CurrentCulture)))
                 .ForMember(m => m.TotalString, opt => opt.MapFrom(s => s.Total.ToString("N0", CultureInfo.CurrentCulture)));
        }
    }
}
