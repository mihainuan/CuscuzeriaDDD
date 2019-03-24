using Cuscuzeria.API.Interface;
using Cuscuzeria.Domain.Entities;

namespace Cuscuzeria.API
{
    public class OrderAppService : AppServiceBase<Order>, IOrderAppService
    {
        private readonly IOrderAppService _orderService;

        public OrderAppService(IOrderAppService orderService)
            : base(orderService)
        {
            _orderService = orderService;
        }

    }
}