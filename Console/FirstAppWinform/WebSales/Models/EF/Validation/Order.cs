using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebSales.Models.EF
{
    [MetadataType(typeof(MetaOrder))]
    public partial class Order
    {
    }

    public class MetaOrder
    {
        [Required(ErrorMessage = "khong duoc de trong!")]
        [MaxLength(50, ErrorMessage = "Do dai khong qua 50 ky tu!")]
        public string CustomerID { get; set; }

        [Required(ErrorMessage = "Ten Tieng Viet loai san pham khong duoc de trong!")]
        [MaxLength(100, ErrorMessage = "Do dai khong qua 50 ky tu!")]
        public string Address { get; set; }

        [Required(ErrorMessage = "khong duoc de trong!")]
        public Nullable<System.DateTime> OrderDate { get; set; }

        [Required(ErrorMessage = "khong duoc de trong!")]
        public Nullable<double> Amount { get; set; }

        [Required(ErrorMessage = "khong duoc de trong!")]
        public string Description { get; set; }
    }
}