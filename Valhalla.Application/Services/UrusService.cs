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
    public class UrusService : IUrusService
    {
        private readonly IUrusRepository _repository;
        private readonly IMapper _mapper;

        public UrusService(IUrusRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public void AddUrus(CreateUrusRequest request)
        {
            var urus = _mapper.Map<Urus>(request);
            _repository.AddUrus(urus);
        }

        public void DeleteUrus(string id)
        {
            _repository.RemoveUrus(id);
        }

        public Urus GetUrus(string id)
        {
            var urus = _repository.GetUrus(id);
            var urusResponse = _mapper.Map<Urus>(urus);
            return urusResponse;
        }

        public IEnumerable<Urus> GetUrus()
        {
            var urus = _repository.GetUrus();
            var urusResponse = _mapper.Map<IEnumerable<Urus>>(urus);
            return urusResponse;
        }

        public void UpdateUrus(UpdateUrusRequest request)
        {
            var urus = _mapper.Map<Urus>(request);
            _repository.UpdateUrus(urus);
        }
    }
}
