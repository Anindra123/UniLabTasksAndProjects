using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ADV_Prog.NET_LAB__2.Models
{
    public class Product
    {
        [Required(ErrorMessage ="Please Enter a product Id")]
        public int Id { get; set; }
        [Required(ErrorMessage ="Please Enter product Name")]
        [MaxLength(10,ErrorMessage ="Product Name can be maximum 10 characters")]
        public string ProductName { get; set; }
        [Required(ErrorMessage ="Please Enter product price")]
        public double Price { get; set; }
    }
}