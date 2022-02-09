using AutoMapper;
using UMApplication.Application.Common.Mappings;
using UMApplication.Domain.Entities;
using System;


namespace UMApplication.Application.Suppliers.Queries
{
    public class SupplierDto : IMapFrom<Supplier>
    {
        public int? Id { get; set; }
        public string Nama { get; set; }
        public string Alamat { get; set; }
        public string ContactPerson { get; set; }
        public string Telepon { get; set; }

        public string Handphone { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Supplier, SupplierDto>()
                .ForMember(m => m.Id, opt => opt.MapFrom(s => s.SupplierId))
                .ForMember(m => m.Nama, opt => opt.MapFrom(s => s.Name))
                .ForMember(m => m.Alamat, opt => opt.MapFrom(s => s.Address))
                .ForMember(m => m.Telepon, opt => opt.MapFrom(s => s.Phone))
                ;
        }
    }
}
