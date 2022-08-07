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
    public class BrandMappingProfile : Profile
    {
        public BrandMappingProfile()
        {
            CreateMap<CreateBrandRequest, Brand>();
            CreateMap<Brand, CreateBrandRequest>();

            CreateMap<UpdateBrandRequest, Brand>();
            CreateMap<Brand, UpdateBrandRequest>();

            CreateMap<DeleteBrandRequest, Brand>();
            CreateMap<Brand, DeleteBrandRequest>();

        }
    }
}
