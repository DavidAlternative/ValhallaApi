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
    public class VehicleMappingProfile : Profile
    {
        public VehicleMappingProfile()
        {
            CreateMap<CreateVehicleRequest, User>();
            CreateMap<User, CreateVehicleRequest>();

            CreateMap<UpdateVehicleRequest, User>();
            CreateMap<User, UpdateVehicleRequest>();

            CreateMap<DeleteVehicleRequest, User>();
            CreateMap<User, DeleteVehicleRequest>();
        }
    }
}
