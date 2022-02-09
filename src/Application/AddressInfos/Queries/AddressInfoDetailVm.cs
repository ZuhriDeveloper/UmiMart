using AutoMapper;
using UMApplication.Application.Common.Mappings;
using UMApplication.Domain.Entities;

namespace UMApplication.Application.AddressInfos.Queries
{
   public class AddressInfoDetailVm : IMapFrom<AddressInfo>
    {
        public int Id { get; set; }
        public string PostalCode { get; set; }
        public string Village { get; set; }
        public string SubDistrict { get; set; }
        public string District { get; set; }
        public string Province { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<AddressInfo, AddressInfoDetailVm>()
                   .ForMember(m => m.Id, opt => opt.MapFrom(s => s.AddressInfoId));
        }
    }
}
