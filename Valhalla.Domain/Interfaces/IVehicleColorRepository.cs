using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Valhalla.Domain.Entities;

namespace Valhalla.Domain.Interfaces
{
    public interface IVehicleColorRepository
    {
        IEnumerable<VehicleColor> GetVehicleColors();
        VehicleColor GetVehicleColor(string id);
        void AddVehicleColor(VehicleColor vehicleColor);
        void UpdateVehicleColor(VehicleColor vehicleColor);
        void RemoveVehicleColor(string id);
    }
}
