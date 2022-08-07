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
    public class VehicleColorRepository : IVehicleColorRepository
    {
        private ValhallaContext _context;

        public VehicleColorRepository(ValhallaContext context)
        {
            _context = context;
        }
        public string generateID()
        {
            return Guid.NewGuid().ToString();
        }
        public IEnumerable<VehicleColor> GetVehicleColors()
        {
            return _context.VehicleColors;
        }
        public VehicleColor GetVehicleColor(string id)
        {
            return _context.VehicleColors.FirstOrDefault(x => x.Idvehicle == id);
        }

        public void AddVehicleColor(VehicleColor vehicleColor)
        {
            vehicleColor.Idcolor = generateID();
            _context.VehicleColors.Add(vehicleColor);
            _context.SaveChanges();
        }
        public void UpdateVehicleColor(VehicleColor vehicleColor)
        {
            var colorE = _context.VehicleColors.FirstOrDefault(x => x.Idcolor == vehicleColor.Idcolor);
            if (colorE != null)
            {
                colorE.Idvehicle = vehicleColor.Idvehicle;
                colorE.Color = vehicleColor.Color;
            }
            _context.SaveChanges();
        }
        public void RemoveVehicleColor(string id)
        {
            var colorE = _context.VehicleColors.FirstOrDefault(x => x.Idcolor == id);
            if (colorE != null)
            {
                _context.Remove(colorE);
            }
            _context.SaveChanges();
        }
    }
}
