using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valhalla.Application.Requests
{
    public class CreateUserRequest
    {
        public string FirstName { get; set; } = null!;
        public string? SecondName { get; set; }
        public string FirstSurname { get; set; } = null!;
        public string SecondSurname { get; set; } = null!;
        public string Email { get; set; } = null!;
        public int Dni { get; set; }
        public DateTime Birthdate { get; set; }
        public string UserPassword { get; set; } = null!;
        public string UserAddress { get; set; } = null!;
        public long? PhoneNumber { get; set; }
        public int ZipCode { get; set; }
    }
}
