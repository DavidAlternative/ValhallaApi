using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Valhalla.Domain.Entities;
using Valhalla.Domain.Interfaces;
using Valhalla.Infrastructure.Persistence;

namespace Valhalla.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        private ValhallaContext _context;

        public UserRepository(ValhallaContext context)
        {
            _context = context;
        }
        public string generateID()
        {
            return Guid.NewGuid().ToString();
        }
        public IEnumerable<User> GetUsers()
        {
            return _context.Users;
        }
        public User GetUser(string id)
        {
            return _context.Users.FirstOrDefault(x => x.Iduser == id);
        }
        public void AddUser(User user)
        {
            user.CreatedAt = DateTime.Now;
            user.Iduser = generateID();
            _context.Users.Add(user);
            _context.SaveChanges();
        }
        public void UpdateUser(User user)
        {
            var userE = _context.Users.FirstOrDefault(x => x.Iduser == user.Iduser);
            if (userE != null)
            {
                userE.FirstName = user.FirstName;
                userE.SecondName = user.SecondName;
                userE.FirstSurname = user.FirstSurname;
                userE.SecondSurname = user.SecondSurname;
                userE.Email = user.Email;
                userE.Dni = user.Dni;
                userE.Birthdate = user.Birthdate;
                userE.UserPassword = user.UserPassword;
                userE.UserAddress = user.UserAddress;
                userE.PhoneNumber = user.PhoneNumber;
                userE.ZipCode = user.ZipCode;
            }
            _context.SaveChanges();
        }
    }
}
