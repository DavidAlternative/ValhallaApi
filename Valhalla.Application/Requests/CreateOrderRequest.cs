using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valhalla.Application.Requests
{
    public class CreateOrderRequest
    {
        public DateTime OrderedAt { get; set; }
        public string Iduser { get; set; } = null!;
        public int Price { get; set; }
        public string UserAddress { get; set; } = null!;
        public int UserPhone { get; set; }
        public int ZipCode { get; set; }
        public string? Idvehicle { get; set; }
        public string? Idurus { get; set; }
    }
}
