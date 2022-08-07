using Valhalla.Domain.Entities;
using Valhalla.Domain.Interfaces;
using Valhalla.Infrastructure.Persistence;

namespace Valhalla.Infrastructure.Repositories
{
    public class BrandRepository : IBrandRepository
    {
        private ValhallaContext _context;
        
        public BrandRepository(ValhallaContext context)
        {
            _context = context;
        }

        public IEnumerable<Brand> GetBrands()
        {
            return _context.Brands;
        }

        public Brand GetBrand(int id)
        {
            return _context.Brands.FirstOrDefault(x => x.Idbrand == id);
        }

        public void AddBrand(Brand brand)
        {
            _context.Brands.Add(brand);
            _context.SaveChanges();
        }

        public void UpdateBrand(Brand brand)
        {
            var brandE = _context.Brands.FirstOrDefault(x => x.Idbrand == brand.Idbrand);
            if (brandE != null)
            {
                brandE.BrandName = brand.BrandName;
                brandE.ImageUrl = brand.ImageUrl;
            }
            _context.SaveChanges();
        }

        public void DeleteBrand(int id) 
        {
            var brandE = _context.Brands.FirstOrDefault(x => x.Idbrand == id);
            if (brandE != null)
            {
                _context.Brands.Remove(brandE);
            }
            _context.SaveChanges();

        }
    }
}
