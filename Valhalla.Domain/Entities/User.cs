using System;
using System.Collections.Generic;

namespace Valhalla.Domain.Entities
{
    public partial class User
    {
        public User()
        {
            Favorites = new HashSet<Favorite>();
            Orders = new HashSet<Order>();
            Urus = new HashSet<Urus>();
        }

        public string Iduser { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string? SecondName { get; set; }
        public string FirstSurname { get; set; } = null!;
        public string SecondSurname { get; set; } = null!;
        public string Email { get; set; } = null!;
        public int Dni { get; set; }
        public DateTime Birthdate { get; set; }
        public string UserPassword { get; set; } = null!;
        public string? UserAddress { get; set; }
        public long? PhoneNumber { get; set; }
        public int ZipCode { get; set; }
        public DateTime CreatedAt { get; set; }

        public virtual ICollection<Favorite> Favorites { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<Urus> Urus { get; set; }
    }
}
