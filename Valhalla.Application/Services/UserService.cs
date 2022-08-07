using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Valhalla.Application.Interfaces;
using Valhalla.Application.Requests;
using Valhalla.Domain.Entities;
using Valhalla.Domain.Interfaces;

namespace Valhalla.Application.Services
{
    public class UserService : IUserService
    {
        private readonly IUserRepository _repository;
        private readonly IMapper _mapper;

        public UserService(IUserRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public void AddUser(CreateUserRequest request)
        {
            var user = _mapper.Map<User>(request);
            _repository.AddUser(user);
        }

        public User GetUser(string id)
        {
            var user = _repository.GetUser(id);
            var userResponse = _mapper.Map<User>(user);
            return userResponse;
        }

        public IEnumerable<User> GetUsers()
        {
            var user = _repository.GetUsers();
            var userResponse = _mapper.Map<IEnumerable<User>>(user);
            return userResponse;
        }

        public void UpdateUser(UpdateUserRequest request)
        {
            var user = _mapper.Map<User>(request);
            _repository.UpdateUser(user);
        }
    }
}
