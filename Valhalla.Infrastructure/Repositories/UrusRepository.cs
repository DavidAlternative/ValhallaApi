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
    public class UrusRepository : IUrusRepository
    {
        private ValhallaContext _context;

        public UrusRepository(ValhallaContext context)
        {
            _context = context;
        }
        public string generateID()
        {
            return Guid.NewGuid().ToString();
        }
        public IEnumerable<Urus> GetUrus()
        {
            return _context.Urus;
        }
        public Urus GetUrus(string id)
        {
            return _context.Urus.FirstOrDefault(x => x.Idurus == id);
        }
        public void AddUrus(Urus urus)
        {
            urus.Idurus = generateID();
            _context.Urus.Add(urus);
            _context.SaveChanges();
        }
        public void UpdateUrus(Urus urus)
        {
            var urusE = _context.Urus.FirstOrDefault(x => x.Idurus == x.Idurus);
            if (urusE != null)
            {
                urusE.Frenos = urus.Frenos;
                urusE.Llantas = urus.Llantas;
                urusE.Pintura = urus.Pintura;
                urusE.Vista = urus.Vista;
                urusE.AsientosElectricos = urus.AsientosElectricos;
                urusE.Cinturones = urus.Cinturones;
                urusE.Bordado = urus.Bordado;
                urusE.AsistenciaAutopista = urus.AsistenciaAutopista;
                urusE.AperturaTraseraSmart = urus.AperturaTraseraSmart;
                urusE.VisionNocturna = urus.VisionNocturna;
                urusE.WashingPackage = urus.WashingPackage;
                urusE.Price = urus.Price;
            }
            _context.SaveChanges();
        }
        public void RemoveUrus(string id)
        {
            var urusE = _context.Urus.FirstOrDefault(x => x.Idurus == id);
            if (urusE != null)
            {
                _context.Urus.Remove(urusE);
            }
            _context.SaveChanges();
        }
    }
}
