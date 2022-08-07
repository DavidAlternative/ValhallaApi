using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Valhalla.Application.Interfaces;
using Valhalla.Application.Requests;
using Valhalla.Domain.Entities;
using Valhalla.Domain.Interfaces;

namespace Valhalla.Application.Services
{
    public class FavoriteService : IFavoriteService
    {
        private readonly IFavoriteRepository _repository;
        private readonly IMapper _mapper;

        public FavoriteService(IFavoriteRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public void AddFavorite(CreateFavoriteRequest request)
        {
            var favorite = _mapper.Map<Favorite>(request);
            _repository.AddFavorite(favorite);
        }

        public void DeleteFavorite(string id)
        {
            _repository.RemoveFavorite(id);
        }

        public Favorite GetFavorite(string id)
        {
            var favorite = _repository.GetFavorite(id);
            var favoriteResponse = _mapper.Map<Favorite>(favorite);
            return favoriteResponse;
        }

        public IEnumerable<Favorite> GetFavorites()
        {
            var favorites = _repository.GetFavorites();
            var favoritesResponse = _mapper.Map<IEnumerable<Favorite>>(favorites);
            return favoritesResponse;
        }
    }
}
