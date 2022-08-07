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
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository _repository;
        private readonly IMapper _mapper;

        public OrderService(IOrderRepository repository, IMapper mapper)
        {
            _repository = repository;
            _mapper = mapper;
        }
        public void AddOrder(CreateOrderRequest request)
        {
            var order = _mapper.Map<Order>(request);
            _repository.AddOrder(order);
        }

        public void DeleteOrder(string id)
        {
            _repository.DeleteOrder(id);
        }

        public Order GetOrder(string id)
        {
            var order = _repository.GetOrder(id);
            var orderResponse = _mapper.Map<Order>(order);
            return orderResponse;
        }

        public IEnumerable<Order> GetOrders()
        {
            var order = _repository.GetOrders();
            var orderResponse = _mapper.Map<IEnumerable<Order>>(order);
            return orderResponse;
        }
    }
}
