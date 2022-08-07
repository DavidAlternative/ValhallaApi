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
    public class FavoriteMappingProfile : Profile
    {
        public FavoriteMappingProfile()
        {
            CreateMap<CreateFavoriteRequest, Favorite>();
            CreateMap<Favorite, CreateFavoriteRequest>();

            CreateMap<DeleteFavoriteRequest, Favorite>();
            CreateMap<Favorite, DeleteFavoriteRequest>();
        }
    }
}
