using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebSales.Models.EF
{
    [MetadataType(typeof(MetaCustomer))]
    public partial class Customer
    {
    }

    public class MetaCustomer
    {
        [Required(ErrorMessage = "Ten khong duoc de trong!")]
        [MaxLength(50, ErrorMessage = "Do dai khong qua 50 ky tu!")]
        public string Fullname { get; set; }

        [Required(ErrorMessage = "khong duoc de trong!")]
        [DataType(DataType.EmailAddress, ErrorMessage = "E-mail is not valid")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        [MaxLength(50, ErrorMessage = "Do dai khong qua 50 ky tu!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "khong duoc de trong!")]
        [MaxLength(20, ErrorMessage = "Do dai khong qua 50 ky tu!")]
        [MinLength(8, ErrorMessage = "Do dai khong it hon 8 ky tu!")]
        public string Password { get; set; }
        
        public string Photo { get; set; }
        public Nullable<bool> Activated { get; set; }
    }
}