using System;
using System.Collections.Generic;

namespace Valhalla.Domain.Entities
{
    public partial class Brand
    {
        public Brand()
        {
            Vehicles = new HashSet<Vehicle>();
        }

        public int Idbrand { get; set; }
        public string BrandName { get; set; } = null!;
        public string ImageUrl { get; set; } = null!;

        public virtual ICollection<Vehicle> Vehicles { get; set; }
    }
}
