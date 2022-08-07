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
    public class VehicleRepository : IVehicleRepository
    {
        private ValhallaContext _context;

        public VehicleRepository(ValhallaContext context)
        {
            _context = context;
        }
        public string generateID()
        {
            return Guid.NewGuid().ToString();
        }
        public IEnumerable<Vehicle> GetVehicles()
        {
            return _context.Vehicles;
        }

        public Vehicle GetVehicle(string id)
        {
            return _context.Vehicles.FirstOrDefault(x => x.Idvehicle == id);
        }

        public void AddVehicle(Vehicle vehicle)
        {
            vehicle.Idvehicle = generateID();
            vehicle.CreatedAt = DateTime.Now;
            _context.Vehicles.Add(vehicle);
            _context.SaveChanges();
        }

        public void UpdateVehicle(Vehicle vehicle)
        {
            var VehicleE = _context.Vehicles.FirstOrDefault(x => x.Idvehicle == vehicle.Idvehicle);
            if (VehicleE != null)
            {
                VehicleE.VehicleName = vehicle.VehicleName;
                VehicleE.Idbrand = vehicle.Idbrand;
                VehicleE.BrandName = vehicle.BrandName;
                VehicleE.IsNew = vehicle.IsNew;
                VehicleE.Price = vehicle.Price;
                VehicleE.ImgUrl = vehicle.ImgUrl;
            }
            _context.SaveChanges();
        }

        public void RemoveVehicle(string id)
        {
            var VehicleE = _context.Vehicles.FirstOrDefault(x => x.Idvehicle == id);
            if (VehicleE != null)
            {
                _context.Vehicles.Remove(VehicleE);
            }

            _context.SaveChanges();
        }
    }
}
