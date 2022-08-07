using System;
using System.Collections.Generic;

namespace Valhalla.Domain.Entities
{
    public partial class Favorite
    {
        public string Idfavorite { get; set; } = null!;
        public string Iduser { get; set; } = null!;
        public string Idvehicle { get; set; } = null!;

        public virtual User IduserNavigation { get; set; } = null!;
        public virtual Vehicle IdvehicleNavigation { get; set; } = null!;
    }
}
