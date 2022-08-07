using System;
using System.Collections.Generic;

namespace Valhalla.Domain.Entities
{
    public partial class Vehicle
    {
        public Vehicle()
        {
            Favorites = new HashSet<Favorite>();
            VehicleColors = new HashSet<VehicleColor>();
            Orders = new HashSet<Order>();
        }

        public string Idvehicle { get; set; } = null!;
        public string VehicleName { get; set; } = null!;
        public int Idbrand { get; set; }
        public string BrandName { get; set; } = null!;
        public int IsNew { get; set; }
        public int Price { get; set; }
        public string ImgUrl { get; set; } = null!;
        public DateTime CreatedAt { get; set; }

        public virtual Brand IdbrandNavigation { get; set; } = null!;
        public virtual ICollection<Favorite> Favorites { get; set; }
        public virtual ICollection<VehicleColor> VehicleColors { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
    }
}
