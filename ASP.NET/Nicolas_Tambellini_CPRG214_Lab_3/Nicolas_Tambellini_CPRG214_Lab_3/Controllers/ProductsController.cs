using Nicolas_Tambellini_CPRG214_Lab_3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Nicolas_Tambellini_CPRG214_Lab_3.Controllers
{
    public class ProductsController : Controller
    {
        /// <summary>
        /// Products Page Controller
        /// </summary>
        /// <returns>Products page with table of products from the DB</returns>
        [HttpGet]
        public ActionResult Products()
        {

            ViewBag.Title = "Products"; // changes title on tab to Products
            try
            {
                List<Product> productList = ProductDB.GetProducts(); // list of products from the DB to populate to the view
                return View(productList);
            }
            catch
            {
                return View(); // returns empty view
            }
            
        }

        /// <summary>
        /// Details Page Controller
        /// </summary>
        /// <param name="id">id of product that was selected</param>
        /// <returns>Details of selected product including long description and image</returns>
        [HttpGet]
        public ActionResult Details(string id)
        {
            ViewBag.Title = "Product Details"; // changes title on tab to Details

            try
            {
                List<Product> productList = ProductDB.GetProducts(); // list of products from the DB
                Product selectedProduct = new Product(); // selected product to display details of

                // loop through products list to find id of selected product
                foreach (Product p in productList)
                {
                    if (p.ProductID == id)
                    {
                        selectedProduct = p;
                    }
                }
                return View(selectedProduct);
            }
            catch
            {
                return View(); // returns empty view
            }
            
        }
    }
}