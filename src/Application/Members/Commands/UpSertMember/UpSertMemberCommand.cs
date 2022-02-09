using MediatR;
using UMApplication.Application.Common.Interfaces;
using UMApplication.Domain.Entities;
using System.Threading;
using System.Threading.Tasks;
using System;

namespace UMApplication.Application.Members.Commands.UpSertMember
{
    public class UpSertMemberCommand : IRequest<int>
    {
        public int? Id { get; set; }
        public string FullName { get; set; }
        public string MembershipNumber { get; set; }
        public string CardNumber { get; set; }
        public string Address { get; set; }
        public decimal Plafon { get; set; }

        public decimal DiscountFlat { get; set; }
        public float DiscountRate { get; set; }

        public bool IsActive { get; set; }

    }
}
