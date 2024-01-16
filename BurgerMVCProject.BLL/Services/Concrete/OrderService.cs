using BurgerMVCProject.BLL.Services.Abstract;
using BurgerMVCProject.Domain.Entities;
using DAL.Repositories.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BurgerMVCProject.BLL.Services.Concrete
{
    public class OrderService : IOrderService
    {
        private readonly IOrderRepository orderRepository;

        public OrderService(IOrderRepository orderRepository)
        {
            this.orderRepository = orderRepository;
        }
        public bool AddOrder(Order order)
        {
            Order order1 = new()
            {
                TotalPrice = order.TotalPrice,
                Quantity = order.Quantity,
                CreatedDate = order.CreatedDate
            };
            return orderRepository.Add(order1);
        }

        public bool DeleteOrder(Order order)
        {
            return orderRepository.Delete(order);
        }

        public List<Order> GetOrders()
        {
            return orderRepository.GetAll().Select(s => new Order
            {
                OrderId = s.OrderId,
                Quantity = s.Quantity,
                TotalPrice = s.TotalPrice,
                CreatedDate = s.CreatedDate
            }).ToList();
        }

        public bool UpdateOrder(Order order)
        {
            Order order1 = new()
            {
                Quantity = order.Quantity,
                ModifiedDate = order.ModifiedDate = DateTime.Now,
                TotalPrice = order.TotalPrice
            };
            return orderRepository.Update(order1);
        }
    }
}
