using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Valhalla.Application.Requests;
using Valhalla.Domain.Entities;

namespace Valhalla.Application.Interfaces
{
    public interface IBrandService
    {
        IEnumerable<Brand> GetBrands();
        Brand GetBrand(int id);
        void AddBrand(CreateBrandRequest brand);
        void UpdateBrand(UpdateBrandRequest brand);
        void DeleteBrand(int id);
    }
}
