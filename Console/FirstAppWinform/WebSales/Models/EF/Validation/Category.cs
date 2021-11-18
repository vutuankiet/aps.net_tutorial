using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebSales.Models.EF
{
    [MetadataType(typeof(MetaCategory))]
    public partial class Category
    {
    }

    public class MetaCategory
    {
        [Required(ErrorMessage = "Ten loai san pham khong duoc de trong!")]
        [MaxLength(50,ErrorMessage = "Do dai khong qua 50 ky tu!")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Ten Tieng Viet loai san pham khong duoc de trong!")]
        [MaxLength(50, ErrorMessage = "Do dai khong qua 50 ky tu!")]
        public string NameVN { get; set; }
    }
}