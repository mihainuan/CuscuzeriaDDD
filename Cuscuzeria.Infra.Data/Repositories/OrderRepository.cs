using Cuscuzeria.Domain.Entities;
using Cuscuzeria.Domain.Interfaces.Repositories;

namespace Cuscuzeria.Infra.Data.Repositories
{
    public class OrderRepository : RepositoryBase<Order>, IOrderRepository
    {
    }
}