using System;
using System.Collections.Generic;

namespace Valhalla.Domain.Entities
{
    public partial class Order
    {
        public string Idorder { get; set; } = null!;
        public DateTime OrderedAt { get; set; }
        public string Iduser { get; set; } = null!;
        public int Price { get; set; }
        public string UserAddress { get; set; } = null!;
        public int UserPhone { get; set; }
        public int ZipCode { get; set; }
        public string? Idvehicle { get; set; }
        public string? Idurus { get; set; }
        public virtual Vehicle IdvehicleNavigation { get; set; } = null!;
        public virtual User IduserNavigation { get; set; } = null!;
        public virtual Urus IdurusNavigation { get; set; } = null!;
    }
}
