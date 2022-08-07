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
    public class OrderRepository : IOrderRepository
    {
        private ValhallaContext _context;

        public OrderRepository(ValhallaContext context)
        {
            _context = context;
        }
        public string generateID()
        {
            return Guid.NewGuid().ToString();
        }
        public IEnumerable<Order> GetOrders()
        {
            return _context.Orders;
        }
        public Order GetOrder(string id)
        {
            return _context.Orders.FirstOrDefault(x => x.Idorder == id);
        }
        public void AddOrder(Order order)
        {
            order.Idorder = generateID();
            order.OrderedAt = DateTime.Now;
            _context.Orders.Add(order);
            _context.SaveChanges();
        }
        public void DeleteOrder(string id)
        {
            var orderE = _context.Orders.FirstOrDefault(x => x.Idorder == id);
            if (orderE != null)
            {
                _context.Orders.Remove(orderE);
            }
            _context.SaveChanges();
        }



    }
}
