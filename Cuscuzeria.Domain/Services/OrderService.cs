using Cuscuzeria.Domain.Entities;
using Cuscuzeria.Domain.Interfaces.Repositories;

namespace Cuscuzeria.Domain.Services
{
    public class OrderService : ServiceBase<Order>, IOrderService
    {
        private readonly IOrderRepository _orderRepository;

        public OrderService(IOrderRepository orderRepository)
            : base(orderRepository)
        {
            _orderRepository = orderRepository;
        }
    }
}