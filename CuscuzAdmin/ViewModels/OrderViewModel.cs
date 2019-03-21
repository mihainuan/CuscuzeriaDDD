using Cuscuzeria.Domain.Enums;
using System;
using System.ComponentModel.DataAnnotations;

namespace CuscuzAdmin.Models
{
    public class OrderViewModel
    {
        public int OrderId { get; set; }
        public int CuscuzeiroId { get; set; }
        public int UserId { get; set; }

        public int BeverageId { get; set; }
        public int CuscuzId { get; set; }
        public int DrinkId { get; set; }
        public int PromoId { get; set; }

        public StatusEnum OrderStatus { get; set; }
        public DateTime OrderCreation { get; set; }
        public bool Delivered { get; set; }

        [DataType(DataType.Currency)]
        [Range(typeof(decimal), "0", "999999999999")]
        [Required(ErrorMessage = "Total Required!")]
        public decimal OrderTotal { get; set; }

        //FK (one-to-one)
        //public virtual Cuscuzeiro Cuscuzeiro { get; set; }
        public virtual UserViewModel User { get; set; }

        //FK (one-to-many)
        //public virtual ICollection<Beverage> Beverages { get; set; }
        //public virtual ICollection<Cuscuz> Cuscuzes { get; set; }
        //public virtual ICollection<Drink> Drinks { get; set; }
        //public virtual ICollection<Promo> Promo { get; set; }


    }
}