using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Valhalla.Application.Requests;
using Valhalla.Domain.Entities;

namespace Valhalla.Application.Interfaces
{
    public interface IOrderService
    {
        IEnumerable<Order> GetOrders();
        Order GetOrder(string id);
        void AddOrder(CreateOrderRequest order);
        void DeleteOrder(string id);
    }
}
