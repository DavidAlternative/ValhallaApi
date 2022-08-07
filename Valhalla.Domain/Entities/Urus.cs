using System;
using System.Collections.Generic;

namespace Valhalla.Domain.Entities
{
    public partial class Urus
    {
        public string Idurus { get; set; } = null!;
        public string Iduser { get; set; } = null!;
        public string? Frenos { get; set; }
        public string? Llantas { get; set; }
        public string? Pintura { get; set; }
        public string? Vista { get; set; }
        public string? AsientosElectricos { get; set; }
        public string? Cinturones { get; set; }
        public string? Bordado { get; set; }
        public string? AsistenciaAutopista { get; set; }
        public string? AperturaTraseraSmart { get; set; }
        public string? VisionNocturna { get; set; }
        public string? WashingPackage { get; set; }
        public int Price { get; set; }

        public virtual User IduserNavigation { get; set; } = null!;
        public virtual ICollection<Order> Orders { get; set; } = null!;
    }
}
