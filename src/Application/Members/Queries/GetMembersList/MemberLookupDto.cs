using AutoMapper;
using UMApplication.Application.Common.Mappings;
using UMApplication.Domain.Entities;
using System;

namespace UMApplication.Application.Members.Queries.GetMembersList
{
   public class MemberLookupDto : IMapFrom<Member>
    {
        public int Id { get; set; }
        public string FullName { get; set; }
        public string MembershipNumber { get; set; }
        public string CardNumber { get; set; }
        public string Address { get; set; }

        public decimal Plafon { get; set; }

        public decimal DiscountFlat { get; set; }
        public float DiscountRate { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Member, MemberLookupDto>()
                   .ForMember(m => m.Id, opt => opt.MapFrom(s => s.MemberId));
        }
    }
}
