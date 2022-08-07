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
    public class BrandService : IBrandService
    {
        private readonly IBrandRepository _repository;
        private readonly IMapper _mapper;

        public BrandService(IBrandRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;   
        }
        public void AddBrand(CreateBrandRequest request)
        {
            var brand = _mapper.Map<Brand>(request);
            _repository.AddBrand(brand);
        }

        public void DeleteBrand(int id)
        {
            _repository.DeleteBrand(id);
        }

        public Brand GetBrand(int id)
        {
            var brand = _repository.GetBrand(id);
            var brandResponse = _mapper.Map<Brand>(brand);
            return brandResponse;
        }

        public IEnumerable<Brand> GetBrands()
        {
            var brand = _repository.GetBrands();
            var brandsResponse = _mapper.Map<IEnumerable<Brand>>(brand);
            return brandsResponse;
        }

        public void UpdateBrand(UpdateBrandRequest request)
        {
            var brand = _mapper.Map<Brand>(request);
            _repository.UpdateBrand(brand);
        }
    }
}
