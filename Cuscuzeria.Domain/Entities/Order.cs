using Cuscuzeria.Domain.Enums;
using System;

namespace Cuscuzeria.Domain.Entities
{
    public class Order
    {
        public int OrderId { get; set; }
        public int UserId { get; set; }
        public int PromoId { get; set; }
        public int DrinkId { get; set; }
        public int BeverageId { get; set; }
        public int CuscuzId { get; set; }
        public int CuscuzeiroId { get; set; }
        public StatusEnum OrderStatus { get; set; }
        public DateTime OrderCreation { get; set; }
        public bool Delivered { get; set; }


    }
}
