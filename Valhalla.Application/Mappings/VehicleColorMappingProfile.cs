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
    public class VehicleColorMappingProfile : Profile
    {
        public VehicleColorMappingProfile()
        {

            CreateMap<CreateVehicleColorRequest, User>();
            CreateMap<User, CreateVehicleColorRequest>();

            CreateMap<UpdateVehicleColorRequest, User>();
            CreateMap<User, UpdateVehicleColorRequest>();

            CreateMap<DeleteVehicleColorRequest, User>();
            CreateMap<User, DeleteVehicleColorRequest>();
        }
    }
}
