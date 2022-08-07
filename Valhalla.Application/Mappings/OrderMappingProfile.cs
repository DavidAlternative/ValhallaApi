using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Valhalla.Application.Requests;
using Valhalla.Domain.Entities;

namespace Valhalla.Application.Mappings
{
    public class OrderMappingProfile : Profile
    {
        public OrderMappingProfile()
        {
            CreateMap<CreateOrderRequest, Order>();
            CreateMap<Order, CreateOrderRequest>();

            CreateMap<DeleteOrderRequest, Order>();
            CreateMap<Order, DeleteOrderRequest>();
        }
    }
}
