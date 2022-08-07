using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Valhalla.Application.Requests;
using Valhalla.Domain.Entities;

namespace Valhalla.Application.Interfaces
{
    public interface IVehicleService
    {
        IEnumerable<Vehicle> GetVehicles();
        Vehicle GetVehicle(string id);
        void AddVehicle(CreateVehicleRequest vehicle);
        void UpdateVehicle(UpdateVehicleRequest vehicle);
        void DeleteVehicle(string id);
    }
}
