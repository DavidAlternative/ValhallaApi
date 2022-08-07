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
    public class VehicleColorService : IVehicleColorService
    {
        private readonly IVehicleColorRepository _repository;
        private readonly IMapper _mapper;

        public VehicleColorService(IVehicleColorRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public void AddVehicleColor(CreateVehicleColorRequest request)
        {
            var vehicleColor = _mapper.Map<VehicleColor>(request);
            _repository.AddVehicleColor(vehicleColor);
        }

        public void DeleteVehicleColor(string id)
        {
            _repository.RemoveVehicleColor(id);
        }

        public VehicleColor GetVehicleColor(string id)
        {
            var vehicleColor = _repository.GetVehicleColor(id);
            var vehicleColorResponse = _mapper.Map<VehicleColor>(vehicleColor);
            return vehicleColorResponse;
        }

        public IEnumerable<VehicleColor> GetVehicleColors()
        {
            var vehicleColor = _repository.GetVehicleColors();
            var vehicleColorResponse = _mapper.Map<IEnumerable<VehicleColor>>(vehicleColor);
            return vehicleColorResponse;
        }

        public void UpdateVehicleColor(UpdateVehicleColorRequest request)
        {
            var vehicleColor = _mapper.Map<VehicleColor>(request);
            _repository.UpdateVehicleColor(vehicleColor);
        }
    }
}
