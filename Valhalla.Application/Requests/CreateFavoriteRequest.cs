using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valhalla.Application.Requests
{
    public class CreateFavoriteRequest
    {
        public string Iduser { get; set; } = null!;
        public string Idvehicle { get; set; } = null!;
    }
}
