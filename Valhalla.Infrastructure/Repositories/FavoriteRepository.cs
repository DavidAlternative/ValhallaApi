using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Valhalla.Domain.Entities;
using Valhalla.Domain.Interfaces;
using Valhalla.Infrastructure.Persistence;

namespace Valhalla.Infrastructure.Repositories
{
    public class FavoriteRepository : IFavoriteRepository
    {
        private ValhallaContext _context;
        public string generateID()
        {
            return Guid.NewGuid().ToString();
        }

        public FavoriteRepository(ValhallaContext context)
        {
            _context = context;
        }
        public IEnumerable<Favorite> GetFavorites()
        {
            return _context.Favorites;
        }
        public Favorite GetFavorite(string id)
        {
            return (Favorite)_context.Favorites.Where(x => x.Iduser == id);
        }
        public void AddFavorite(Favorite favorite)
        {
            favorite.Idfavorite = generateID();
            _context.Favorites.Add(favorite);
        }
        public void RemoveFavorite(string id)
        {
            var favoriteE = _context.Favorites.FirstOrDefault(x => x.Idfavorite == id);
            if (favoriteE != null)
            {
                _context.Favorites.Remove(favoriteE);
            }
            _context.SaveChanges();
        }



    }
}
