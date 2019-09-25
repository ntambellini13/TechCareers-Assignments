using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Nicolas_Tambellini_CPRG214_Lab_3.Models
{
    public class Product
    {
        [Required(ErrorMessage = "A Product ID is required")]
        [StringLength(10)]
        public string ProductID { get; set; } // Product ID

        [Required(ErrorMessage = "A product name is required")]
        [StringLength(50)]
        public string Name { get; set; } // Product Name

        [Required(ErrorMessage = "A short product description of less than 200 characters is required")]
        [StringLength(200)]
        public string ShortDescription { get; set; } // Short Description of Product

        [Required(ErrorMessage = "A product description of less than 2000 characters is required")]
        [StringLength(2000)]
        public string LongDescription { get; set; } // Long and detailed Description of Product

        [Required(ErrorMessage = "A Category ID is required")]
        [StringLength(10)]
        public string CategoryID { get; set; } // Product Category ID

        [StringLength(30)]
        public string ImageFile { get; set; } // Image file path for product

        [Required(ErrorMessage = "The product needs a price")]
        public decimal UnitPrice { get; set; } // Price of Product

        [Required(ErrorMessage = "The quantity of the product is needed")]
        public int OnHand { get; set; } // Quantity of product available on hand
    }
}