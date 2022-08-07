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
    public class UrusMappingProfile : Profile
    {
        public UrusMappingProfile()
        {
            CreateMap<CreateUrusRequest, Urus>();
            CreateMap<Urus, CreateUrusRequest>();

            CreateMap<UpdateUrusRequest, Urus>();
            CreateMap<Urus, UpdateUrusRequest>();

            CreateMap<DeleteUrusRequest, Urus>();
            CreateMap<Urus, DeleteUrusRequest>();
        }
    }
}
