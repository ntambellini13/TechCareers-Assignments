using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Nicolas_Tambellini_CPRG214_Lab_3.Models
{
    public class Product
    {
        public string ProductID { get; set; } // Product ID
        public string Name { get; set; } // Product Name
        public string ShortDescription { get; set; } // Short Description of Product
        public string LongDescription { get; set; } // Long and detailed Description of Product
        public string CategoryID { get; set; } // Product Category ID
        public string ImageFile { get; set; } // Image file path for product
        public decimal UnitPrice { get; set; } // Price of Product
        public int OnHand { get; set; } // Quantity of product available on hand
    }
}