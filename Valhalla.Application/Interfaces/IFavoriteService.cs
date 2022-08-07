using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Valhalla.Application.Requests;
using Valhalla.Domain.Entities;

namespace Valhalla.Application.Interfaces
{
    public interface IFavoriteService
    {
        IEnumerable<Favorite> GetFavorites();
        Favorite GetFavorite(string id);
        void AddFavorite(CreateFavoriteRequest favorite);
        void DeleteFavorite(string id);
    }
}
