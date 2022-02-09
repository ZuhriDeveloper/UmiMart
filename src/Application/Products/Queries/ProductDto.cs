using AutoMapper;
using UMApplication.Application.Common.Mappings;
using UMApplication.Domain.Entities;
using System;

namespace UMApplication.Application.Products.Queries
{
   public class ProductDto : IMapFrom<Product>
    {
        public ProductDto()
        {
            IsSelected = false;
        }
        public int? Id { get; set; }

        public string PLU { get; set; }
        public string Deskripsi { get; set; }
        public string Barcode { get; set; }
        public string Hpp { get; set; }
        public float Ppn { get; set; }

        public string Margin { get; set; }
        public string HargaJual { get; set; }

        public bool IsSelected { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Product, ProductDto>()
                .ForMember(m => m.Id, opt => opt.MapFrom(s => s.ProductId))
                .ForMember(m => m.PLU, opt => opt.MapFrom(s => s.Code))
                .ForMember(m => m.Deskripsi, opt => opt.MapFrom(s => s.Name))
                .ForMember(m => m.Barcode, opt => opt.MapFrom(s => s.Barcode))
                .ForMember(m => m.HargaJual, opt => opt.MapFrom(s => s.SellPrice.ToString("N0")))
                .ForMember(m => m.Hpp, opt => opt.MapFrom(s => s.Hpp.ToString("N0")))
                .ForMember(m => m.Margin, opt => opt.MapFrom(s => s.Margin.ToString("N0")))
                ;
        }
    }
}
