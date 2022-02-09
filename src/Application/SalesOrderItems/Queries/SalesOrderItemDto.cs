using AutoMapper;
using UMApplication.Application.Common.Mappings;
using UMApplication.Domain.Entities;
using System;

namespace UMApplication.Application.SalesOrderItems.Queries
{
    public class SalesOrderItemDto : IMapFrom<SalesOrderItem>
    {
        public int SalesOrderId { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<SalesOrderItem, SalesOrderItemDto>();
        }
    }
}
