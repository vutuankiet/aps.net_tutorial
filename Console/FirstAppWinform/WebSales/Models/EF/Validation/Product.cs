using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebSales.Models.EF
{
    [MetadataType(typeof(MetaProduct))]
    public partial class Product
    {
    }

    public class MetaProduct
    {
        [Required(ErrorMessage = "Ten khong duoc de trong!")]
        [MaxLength(50, ErrorMessage = "Do dai khong qua 50 ky tu!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "khong duoc de trong!")]
        public Nullable<double> UnitPrice { get; set; }

        [Required(ErrorMessage = "khong duoc de trong!")]
        public string Image { get; set; }

        [Required(ErrorMessage = "khong duoc de trong!")]
        public Nullable<System.DateTime> ProductDate { get; set; }

        [Required(ErrorMessage = "khong duoc de trong!")]
        public Nullable<bool> Available { get; set; }

        [Required(ErrorMessage = "khong duoc de trong!")]
        public Nullable<int> CategoryID { get; set; }

        [Required(ErrorMessage = "khong duoc de trong!")]
        [MaxLength(50, ErrorMessage = "Do dai khong qua 50 ky tu!")]
        public string Description { get; set; }
    }
}