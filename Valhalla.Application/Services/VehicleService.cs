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
    public class VehicleService : IVehicleService
    {
        private readonly IVehicleRepository _repository;
        private readonly IMapper _mapper;

        public VehicleService(IVehicleRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public void AddVehicle(CreateVehicleRequest request)
        {
            var vehicle = _mapper.Map<Vehicle>(request);
            _repository.AddVehicle(vehicle);
        }

        public void DeleteVehicle(string id)
        {
            _repository.RemoveVehicle(id);
        }

        public Vehicle GetVehicle(string id)
        {
            var vehicle = _repository.GetVehicle(id);
            var vehicleResponse = _mapper.Map<Vehicle>(vehicle);
            return vehicleResponse;
        }

        public IEnumerable<Vehicle> GetVehicles()
        {
            var vehicle = _repository.GetVehicles();
            var vehicleResponse = _mapper.Map<IEnumerable<Vehicle>>(vehicle);
            return vehicleResponse;
        }

        public void UpdateVehicle(UpdateVehicleRequest request)
        {
            var vehicle = _mapper.Map<Vehicle>(request);
            _repository.UpdateVehicle(vehicle);
        }
    }
}
