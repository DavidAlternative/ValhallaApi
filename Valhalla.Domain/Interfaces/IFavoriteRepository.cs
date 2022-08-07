using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Valhalla.Domain.Entities;

namespace Valhalla.Domain.Interfaces
{
    public interface IFavoriteRepository
    {
        IEnumerable<Favorite> GetFavorites();
        Favorite GetFavorite(string id);
        void AddFavorite (Favorite favorite);
        void RemoveFavorite (string id);
    }
}
