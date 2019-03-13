using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace CuscuzeriaDDD.MVC.ViewlModels
{
    public class OrderViewModel
    {
        [Key]
        public int OrderId { get; set; }

        public int CuscuzeiroId { get; set; }
        public int UserId { get; set; }
        public int BeverageId { get; set; }
        public int CuscuzId { get; set; }
        public int DrinkId { get; set; }
        public int PromoId { get; set; }

        public int OrderStatus { get; set; }
        public DateTime OrderCreation { get; set; }

        [DisplayName("Delivered?")]
        public bool Delivered { get; set; }

        [DataType((DataType.Currency))]
        [Range(typeof(decimal), "0", "999999999999")]
        [Required(ErrorMessage = "Please insert a number value")]
        public decimal OrderTotal { get; set; }

        //FK (one-to-one)
        //public virtual Cuscuzeiro Cuscuzeiro { get; set; }
        public virtual UserViewModel User { get; set; }


        //FK (one-to-many)
        //    public virtual ICollection<Beverage> Beverages { get; set; }
        //    public virtual ICollection<Cuscuz> Cuscuzes { get; set; }
        //    public virtual ICollection<Drink> Drinks { get; set; }
        //    public virtual ICollection<Promo> Promo { get; set; }
        //
    }
}