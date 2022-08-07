using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valhalla.Application.Requests
{
    public class UpdateVehicleRequest
    {
        public string VehicleName { get; set; } = null!;
        public int Idbrand { get; set; }
        public string BrandName { get; set; } = null!;
        public int IsNew { get; set; }
        public int Price { get; set; }
        public string ImgUrl { get; set; } = null!;
    }
}
