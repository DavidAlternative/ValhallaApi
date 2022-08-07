using System;
using System.Collections.Generic;

namespace Valhalla.Domain.Entities
{
    public partial class JwtAuthentication
    {
        public string Username { get; set; } = null!;
        public string Password { get; set; } = null!;
    }
}
