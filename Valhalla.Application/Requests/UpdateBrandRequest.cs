using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valhalla.Application.Requests
{
    public class UpdateBrandRequest
    {
        public string BrandName { get; set; } = null!;
        public string ImageUrl { get; set; } = null!;
    }
}
