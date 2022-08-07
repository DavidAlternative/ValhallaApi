using System;
using System.Collections.Generic;

namespace Valhalla.Domain.Entities
{
    public partial class VehicleColor
    {
        public string Idcolor { get; set; } = null!;
        public string Color { get; set; } = null!;
        public string Idvehicle { get; set; } = null!;

        public virtual Vehicle IdvehicleNavigation { get; set; } = null!;
    }
}
