using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Valhalla.Application.Requests;
using Valhalla.Domain.Entities;

namespace Valhalla.Application.Interfaces
{
    public interface IVehicleColorService
    {
        IEnumerable<VehicleColor> GetVehicleColors();
        VehicleColor GetVehicleColor(string id);
        void AddVehicleColor(CreateVehicleColorRequest vehicleColor);
        void UpdateVehicleColor(UpdateVehicleColorRequest vehicleColor);
        void DeleteVehicleColor(string id);
    }
}
