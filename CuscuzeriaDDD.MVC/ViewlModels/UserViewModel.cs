using System;
using System.ComponentModel.DataAnnotations;

namespace CuscuzeriaDDD.MVC.ViewlModels
{
    public class UserViewModel
    {
        [Key]
        public int UserId { get; set; }

        [Required(ErrorMessage = "Username is required!")]
        [MaxLength(150, ErrorMessage = "Maximum size: 150")]
        [MinLength(5, ErrorMessage = "Minimum size: 5")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Password is required!")]
        [MaxLength(150, ErrorMessage = "Maximum size: 150")]
        [MinLength(3, ErrorMessage = "Minimum size: 3")]
        public string Password { get; set; }

        [Required(ErrorMessage = "Password is required!")]
        [MaxLength(150, ErrorMessage = "Maximum size: 150")]
        [MinLength(10, ErrorMessage = "Minimum size: 10")]
        public string Email { get; set; }

        [Required(ErrorMessage = "E-Mail is required!")]
        [EmailAddress(ErrorMessage = "Valid E-mails only!")]
        public string Phone { get; set; }

        [ScaffoldColumn(false)]
        public DateTime CreatedAt { get; set; }

        public DateTime? LastOrder { get; set; }
        public string UrlImg { get; set; }

        public virtual OrderViewModel Order { get; set; }
    }
}
