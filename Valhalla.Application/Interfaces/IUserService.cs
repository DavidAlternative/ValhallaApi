using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Valhalla.Application.Requests;
using Valhalla.Domain.Entities;

namespace Valhalla.Application.Interfaces
{
    public interface IUserService
    {
        IEnumerable<User> GetUsers();
        User GetUser(string id);
        void AddUser(CreateUserRequest brand);
        void UpdateUser(UpdateUserRequest brand);
    }
}
